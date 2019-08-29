using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;

namespace FitnessCenterStereo.Service
{
    internal class ScheduleService : IScheduleService
    {
        #region Constructors

        public ScheduleService(IScheduleRepository scheduleRepository)
        {
            ScheduleRepository = scheduleRepository;
        }

        #endregion Constructors

        #region Properties

        protected IScheduleRepository ScheduleRepository { get; private set; }

        #endregion Properties

        #region Methods

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

        #endregion Methods
    }
}