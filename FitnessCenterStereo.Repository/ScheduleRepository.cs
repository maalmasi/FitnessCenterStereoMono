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

    class ScheduleRepository : IScheduleRepository
    {
        protected ApplicationDbContext AppDbContext { get; private set; }
        private readonly IMapper Mapper;
        public ScheduleRepository(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            AppDbContext = applicationDbContext;
            Mapper = mapper;
        }

        public PaginatedList<ISchedule> Find(IFilter filter)
        {
            IQueryable<Schedule> schedules = AppDbContext.Schedule.AsNoTracking();

            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                schedules = schedules.Where(sch => sch.Id.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || sch.Frequency.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || sch.PlanId.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToLowerInvariant()) || String.Format("{0:s}",sch.DateCreated).ToUpperInvariant().Contains(filter.ToString().ToUpperInvariant()) || String.Format("{0:s}",sch.DateUpdated).ToUpperInvariant().Contains(filter.ToString().ToUpperInvariant()));
            }

            switch (filter.SortBy.ToLowerInvariant())
            {
                case "frequency":
                    if (!filter.SortAscending)
                        schedules = schedules.OrderByDescending(sch => sch.Frequency);
                    else
                        schedules = schedules.OrderBy(sch => sch.Frequency);

                    break;
                case "dateupdated":
                    if (!filter.SortAscending)
                        schedules = schedules.OrderByDescending(sch => sch.DateUpdated);
                    else
                        schedules = schedules.OrderBy(sch => sch.DateUpdated);
                    break;

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }

            var count = schedules.Count();

            var items = schedules.Skip((filter.Page - 1) * filter.RecordsPerPage).Take(filter.RecordsPerPage).ToList();


            return new PaginatedList<ISchedule>(Mapper.Map<IEnumerable<ISchedule>>(items), count, filter.Page, filter.RecordsPerPage);

        }

        public ISchedule Create(ISchedule schedule)
        {
            schedule.Id = Guid.NewGuid();
            schedule.DateCreated = DateTime.UtcNow;
            schedule.DateUpdated = DateTime.UtcNow;
            AppDbContext.Schedule.Add(Mapper.Map<Schedule>(schedule));
            AppDbContext.SaveChanges();
            return schedule;
        }

        public bool Delete(Guid id)
        {
            var toDelete = AppDbContext.Schedule.Find(id);
            AppDbContext.Schedule.Remove(toDelete);
            return AppDbContext.SaveChanges() == 1;
        }

        public bool Update(ISchedule schedule)
        {
            AppDbContext.Schedule.Update(Mapper.Map<Schedule>(schedule));
            return AppDbContext.SaveChanges() == 1;
        }

        public ISchedule Get(Guid id)
        {
            return Mapper.Map<ISchedule>(AppDbContext.Schedule.Find(id));
        }
    }
}
