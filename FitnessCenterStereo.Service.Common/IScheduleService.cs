using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
    public interface IScheduleService
    {
        IEnumerable<ISchedule> Find(IFilter filter);
        ISchedule Create(ISchedule schedule);
        bool Delete(Guid id);
        bool Update(ISchedule schedule);
        ISchedule Get(Guid id);
    }
}
