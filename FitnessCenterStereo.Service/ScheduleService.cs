using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;

namespace FitnessCenterStereo.Service
{
    class ScheduleService
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
            if (ScheduleRepository.Delete(id))
                return true;
            else return false;
        }

        public IEnumerable<ISchedule> Find(IFilter filter)
        {
            return ScheduleRepository.Find(filter);
        }

        public ISchedule Get(Guid id)
        {
            return ScheduleRepository.Get(id);
        }

        public bool Update(ISchedule schedule)
        {
            if (ScheduleRepository.Update(schedule))
                return true;
            else return false;
        }

    }
}
}
