using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;

namespace FitnessCenterStereo.Service
{
    class ScheduleService : IScheduleService
    {
        public ScheduleService(IScheduleRepository scheduleRepository)
        {
            ScheduleRepository = scheduleRepository;
        }

        protected IScheduleRepository ScheduleRepository { get; private set; }

        public ISchedule Create(ISchedule schedule)
        {
            return ScheduleRepository.Create(schedule);
        }

        public bool Delete(Guid id)
        {
            return ScheduleRepository.Delete(id);
        }

        public PaginatedList<ISchedule> Find(IFilter filter)
        {
            return ScheduleRepository.Find(filter);
        }

        public ISchedule Get(Guid id)
        {
            return ScheduleRepository.Get(id);
        }

        public bool Update(ISchedule schedule)
        {
            return ScheduleRepository.Update(schedule);
        }

    }

}
