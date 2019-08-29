using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Service.Common
{
    public interface IScheduleService
    {
        #region Methods

        ISchedule Create(ISchedule schedule);

        bool Delete(Guid id);

        PaginatedList<ISchedule> Find(IScheduleFilter filter);

        ISchedule Get(Guid id);

        bool Update(ISchedule schedule);

        #endregion Methods
    }
}