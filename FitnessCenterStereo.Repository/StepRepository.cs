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
using System.Text;

namespace FitnessCenterStereo.Repository
{

    class StepRepositoy : IStepRepository
    {
        protected ApplicationDbContext AppDbContext { get; private set; }
        private readonly IMapper Mapper;

        public StepRepositoy(ApplicationDbContext dbContext, IMapper mapper)
        {
            AppDbContext = dbContext;
            Mapper = mapper;

        }
        public IStep Create(IStep step)
        {
            step.Id = Guid.NewGuid();
            step.DateCreated = DateTime.UtcNow;
            step.DateUpdated = DateTime.UtcNow;
            AppDbContext.Step.Add(Mapper.Map<Step>(step));
            AppDbContext.SaveChanges();
            return step;
        }

        public bool Delete(Guid id)
        {
            var toDelete = AppDbContext.BodyPartType.Find(id);
            AppDbContext.BodyPartType.Remove(toDelete);
            return AppDbContext.SaveChanges() == 1;
        }

        public PaginatedList<IStep> Find(IFilter filter)
        {
            IQueryable<Step> step = AppDbContext.Step.AsNoTracking();

            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                step = step.Where(st => st.Abbreaviaton.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant())|| st.Name.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant())|| st.Description.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant())||st.Id.Equals(filter.SearchQuery)||st.DateUpdated.Equals(filter.SearchQuery)||st.DateCreated.Equals(filter.SearchQuery));
            }

            switch (filter.SortBy.ToLowerInvariant())
            {
                case "name":
                    if (!filter.SortAscending)
                        step = step.OrderByDescending(st => st.Name);
                    else
                        step = step.OrderBy(st => st.Name);

                    break;
                case "abbr":
                    if (!filter.SortAscending)
                        step = step.OrderByDescending(st => st.Abbreaviaton);
                    else
                        step = step.OrderBy(st => st.Abbreaviaton);
                    break;
                case "datecreated":
                    if (!filter.SortAscending)
                        step = step.OrderByDescending(st => st.DateCreated);
                    else
                        step = step.OrderBy(st => st.DateCreated);
                    break;
                case "dateupdated":
                    if (!filter.SortAscending)
                        step = step.OrderByDescending(st => st.DateUpdated);
                    else
                        step = step.OrderBy(st => st.DateUpdated);
                    break;

                case "id":
                    if (!filter.SortAscending)
                        step = step.OrderByDescending(st => st.Id);
                    else
                        step = step.OrderBy(st => st.Id);
                    break;

                case "description":
                    if (!filter.SortAscending)
                        step = step.OrderByDescending(st => st.Description);
                    else
                        step = step.OrderBy(st => st.Description);
                    break;

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }

            var count = step.Count();

            var items = step.Skip((filter.Page - 1) * filter.RecordsPerPage).Take(filter.RecordsPerPage).ToList();


            return new PaginatedList<IStep>(Mapper.Map<IEnumerable<IStep>>(items), count, filter.Page, filter.RecordsPerPage);
        }

        public IStep Get(Guid id)
        {
            return Mapper.Map<IStep>(AppDbContext.Step.Find(id));
        }

        public bool Update(IStep step)
        {
            if (AppDbContext.Step.Find(step.Id) != null)
            {
                AppDbContext.Step.Update(Mapper.Map<Step>(step));
                return AppDbContext.SaveChanges() == 1;
            }
            return false;
        }
    }
}
