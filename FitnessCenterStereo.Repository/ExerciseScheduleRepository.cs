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
    class ExerciseScheduleRepository : IExerciseScheduleRepository
    {
        protected ApplicationDbContext AppDbContext { get; private set; }
        private readonly IMapper mapper;
        public ExerciseScheduleRepository(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            AppDbContext = applicationDbContext;
            this.mapper = mapper;

        }
        public IExerciseSchedule Create(IExerciseSchedule exerciseSchedule)
        {
            exerciseSchedule.Id = Guid.NewGuid();
            exerciseSchedule.DateCreated = DateTime.UtcNow;
            exerciseSchedule.DateUpdated = DateTime.UtcNow;
            AppDbContext.ExerciseSchedule.Add(mapper.Map<ExerciseSchedule>(exerciseSchedule));
            AppDbContext.SaveChanges();
            return exerciseSchedule;
        }

        public bool Delete(Guid id)
        {
            var toDelete = AppDbContext.ExerciseSchedule.Find(id);
            AppDbContext.ExerciseSchedule.Remove(toDelete);
            AppDbContext.SaveChanges();
            return AppDbContext.SaveChanges() == 1;
        }

        public PaginatedList<IExerciseSchedule> Find(IFilter filter)
        {
            IQueryable<ExerciseSchedule> exSch = AppDbContext.ExerciseSchedule.AsNoTracking();

            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                exSch = exSch.Where(c => c.Id.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.ScheduleId.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.ExercisesId.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || String.Format("{0:s}", c.DateCreated).ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || String.Format("{0:s}", c.DateUpdated).ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()));
            }
            switch (filter.SortBy.ToLowerInvariant())
            {
                case "dateupdated":
                    if (!filter.SortAscending)
                        exSch = exSch.OrderByDescending(c => c.DateUpdated);
                    else
                        exSch = exSch.OrderBy(c => c.DateUpdated);
                    break;

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }

            var count = exSch.Count();

            var items = exSch.Skip((filter.Page - 1) * filter.RecordsPerPage).Take(filter.RecordsPerPage).ToList();


            return new PaginatedList<IExerciseSchedule>(mapper.Map<IEnumerable<IExerciseSchedule>>(items), count, filter.Page, filter.RecordsPerPage);
        }

        public IExerciseSchedule Get(Guid id)
        {
            return mapper.Map<IExerciseSchedule>(AppDbContext.ExerciseSchedule.Find(id));
        }

        public bool Update(IExerciseSchedule card)
        {
            if (AppDbContext.ExerciseSchedule.Find(card).Id == card.Id)
            {
                AppDbContext.ExerciseSchedule.Update(mapper.Map<ExerciseSchedule>(card));
                return AppDbContext.SaveChanges() == 1;
            }
            return false;

        }
    }
}
