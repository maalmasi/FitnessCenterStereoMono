using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IScheduleRepository
    {
        #region Methods

        ISchedule Create(ISchedule schedule);

        bool Delete(Guid id);

        PaginatedList<ISchedule> Find(IFilter filter);

        ISchedule Get(Guid id);

        bool Update(ISchedule ISchedule);

        #endregion Methods
    }
}