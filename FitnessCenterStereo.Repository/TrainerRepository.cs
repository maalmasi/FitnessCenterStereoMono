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
    class TrainerRepository : ITrainerRepository
    {
        protected ApplicationDbContext AppDbContext { get; private set; }
        private readonly IMapper Mapper;

        public TrainerRepository(ApplicationDbContext dbcontext, IMapper mapper)
        {
            AppDbContext = dbcontext;
            Mapper = mapper;
        }
        public ITrainer Create(ITrainer trainer)
        {
            trainer.Id = Guid.NewGuid();
            trainer.DateCreated = DateTime.UtcNow;
            trainer.DateUpdated = DateTime.UtcNow;
            AppDbContext.Trainer.Add(Mapper.Map<Trainer>(trainer));
            AppDbContext.SaveChanges();
            return trainer;
        }

        public bool Delete(Guid id)
        {
            var toDelete = AppDbContext.Trainer.Find(id);
            AppDbContext.Trainer.Remove(toDelete);
            return AppDbContext.SaveChanges() == 1;
        }

        public PaginatedList<ITrainer> Find(IFilter filter)
        {
            IQueryable<Trainer> trainer = AppDbContext.Trainer.AsNoTracking();

            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                trainer = trainer.Where(tr => tr.FirstName.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || tr.LastName.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) ||tr.HiredAt.ToString().Contains(filter.SearchQuery) );
            }

            switch (filter.SortBy.ToLowerInvariant())
            {
                case "firstname":
                    if (!filter.SortAscending)
                        trainer = trainer.OrderByDescending(tr => tr.FirstName);
                    else
                        trainer = trainer.OrderBy(tr => tr.FirstName);

                    break;
                case "lastname":
                    if (!filter.SortAscending)
                        trainer = trainer.OrderByDescending(tr => tr.LastName);
                    else
                        trainer = trainer.OrderBy(tr => tr.LastName);
                    break;
                case "hiredat":
                    if (!filter.SortAscending)
                        trainer = trainer.OrderByDescending(tr => tr.HiredAt);
                    else
                        trainer = trainer.OrderBy(tr => tr.HiredAt);
                    break;

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }

            var count = trainer.Count();

            var items = trainer.Skip((filter.Page - 1) * filter.RecordsPerPage).Take(filter.RecordsPerPage).ToList();


            return new PaginatedList<ITrainer>(Mapper.Map<IEnumerable<ITrainer>>(items), count, filter.Page, filter.RecordsPerPage);
        }

        public ITrainer Get(Guid id)
        {
            return Mapper.Map<ITrainer>(AppDbContext.Trainer.Find(id));
        }

        public bool Update(ITrainer trainer)
        {
            if (AppDbContext.Trainer.Find(trainer.Id) != null)
            {
                AppDbContext.Trainer.Update(Mapper.Map<Trainer>(trainer));
                return AppDbContext.SaveChanges() == 1;
            }
            return false;
        }
    }
}
