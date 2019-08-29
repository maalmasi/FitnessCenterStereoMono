using AutoMapper;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.DAL.Data;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FitnessCenterStereo.Repository
{
    internal class PlanRepository : IPlanRepository
    {
        #region Fields

        private readonly IMapper Mapper;

        #endregion Fields

        #region Constructors

        public PlanRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            Mapper = mapper;
            AppDbContext = dbContext;
        }

        #endregion Constructors

        #region Properties

        protected ApplicationDbContext AppDbContext { get; private set; }

        #endregion Properties

        #region Methods

        public IPlan Create(IPlan plan)
        {
            plan.Id = Guid.NewGuid();
            plan.DateCreated = DateTime.UtcNow;
            plan.DateUpdated = DateTime.UtcNow;
            AppDbContext.Plan.Add(Mapper.Map<Plan>(plan));
            AppDbContext.SaveChanges();
            return plan;
        }

        public bool Delete(Guid id)
        {
            var toDelete = AppDbContext.Plan.Find(id);
            AppDbContext.Plan.Remove(toDelete);
            AppDbContext.SaveChanges();
            return AppDbContext.SaveChanges() == 1;
        }

        public PaginatedList<IPlan> Find(IFilter filter)
        {
            IQueryable<Plan> plan = AppDbContext.Plan.AsNoTracking();

            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                plan = plan.Where(c => c.Id.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || String.Format("{0:s}", c.DateUpdated).ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || String.Format("{0:s}", c.DateCreated).ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.Name.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.DietTypeId.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()));
            }
            switch (filter.SortBy.ToLowerInvariant())
            {
                case "name":
                    if (!filter.SortAscending)
                        plan = plan.OrderByDescending(c => c.Name);
                    else
                        plan = plan.OrderBy(c => c.Name);
                    break;

                case "dateupdated":
                    if (!filter.SortAscending)
                        plan = plan.OrderByDescending(c => c.DateUpdated);
                    else
                        plan = plan.OrderBy(c => c.DateUpdated);

                    break;

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }

            var count = plan.Count();

            var items = plan.Skip((filter.Page - 1) * filter.RecordsPerPage).Take(filter.RecordsPerPage).ToList();

            return new PaginatedList<IPlan>(Mapper.Map<IEnumerable<IPlan>>(items), count, filter.Page, filter.RecordsPerPage);
        }

        public IPlan Get(Guid id)
        {
            return Mapper.Map<IPlan>(AppDbContext.Plan.Find(id));
        }

        public bool Update(IPlan plan)
        {
            if (AppDbContext.Plan.Find(plan).Id == plan.Id)
            {
                AppDbContext.Plan.Update(Mapper.Map<Plan>(plan));
                return AppDbContext.SaveChanges() == 1;
            }
            return false;
        }

        #endregion Methods
    }
}