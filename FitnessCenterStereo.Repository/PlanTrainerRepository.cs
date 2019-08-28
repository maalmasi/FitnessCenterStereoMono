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
    class PlanTrainerRepository : IPlanTrainerRepository
    {
        protected ApplicationDbContext AppDbContext { get; private set; }
        private readonly IMapper Mapper;
       
        public PlanTrainerRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            AppDbContext = dbContext;
            Mapper = mapper;
        }
        public IPlanTrainer Create(IPlanTrainer planTrainer)
        {
            planTrainer.DateCreated = DateTime.UtcNow;
            planTrainer.DateUpdated = DateTime.UtcNow;
            planTrainer.Id = Guid.NewGuid();
            AppDbContext.PlanTrainer.Add(Mapper.Map<PlanTrainer>(planTrainer));
            return planTrainer;


        }

        public bool Delete(Guid id)
        {
            var toDelete = AppDbContext.PlanTrainer.Find(id);
            AppDbContext.PlanTrainer.Remove(toDelete);
            return AppDbContext.SaveChanges() == 1;
        }

        public PaginatedList<IPlanTrainer> Find(IFilter filter)
        {
            IQueryable<PlanTrainer> planTrainer = AppDbContext.PlanTrainer.AsNoTracking();
            //select bpt;

            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                planTrainer = planTrainer.Where(plt => plt.Id.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || plt.TrainerId.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || String.Format("{0:s}", plt.DateUpdated).ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || plt.PlanId.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()));
            }

            switch (filter.SortBy.ToLowerInvariant())
            {
                case "planid":
                    if (!filter.SortAscending)
                        planTrainer = planTrainer.OrderByDescending(pln => pln.PlanId);
                    else
                        planTrainer = planTrainer.OrderBy(pln => pln.PlanId);

                    break;
                case "dateupdated":
                    if (!filter.SortAscending)
                        planTrainer = planTrainer.OrderByDescending(pln => pln.DateUpdated);
                    else
                        planTrainer = planTrainer.OrderBy(pln => pln.DateUpdated);
                    break;

                case "trainerid":
                    if (!filter.SortAscending)
                        planTrainer = planTrainer.OrderByDescending(pln => pln.TrainerId);
                    else
                        planTrainer = planTrainer.OrderBy(pln => pln.DateUpdated);
                    break;

                
            }

            var count = planTrainer.Count();

            var items = planTrainer.Skip((filter.Page - 1) * filter.RecordsPerPage).Take(filter.RecordsPerPage).ToList();


            return new PaginatedList<IPlanTrainer>(Mapper.Map<IEnumerable<IPlanTrainer>>(items), count, filter.Page, filter.RecordsPerPage);

        }

        public IPlanTrainer Get(Guid id)
        {
            return Mapper.Map<IPlanTrainer>(AppDbContext.PlanTrainer.Find(id));
        }

        public bool Update(IPlanTrainer planTrainer)
        {
            AppDbContext.PlanTrainer.Update(Mapper.Map<PlanTrainer>(planTrainer));
            return AppDbContext.SaveChanges() == 1;
        }
    }
}
