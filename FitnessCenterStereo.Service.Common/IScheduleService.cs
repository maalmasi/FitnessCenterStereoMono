using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
    public interface IScheduleService
    {
        PaginatedList<ISchedule> Find(IFilter filter);
        ISchedule Create(ISchedule schedule);
        bool Delete(Guid id);
        bool Update(ISchedule schedule);
        ISchedule Get(Guid id);
    }
}
