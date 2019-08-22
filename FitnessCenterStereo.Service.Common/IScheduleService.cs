using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
    public interface IScheduleService
    {
        IEnumerable<ISchedule> Find(ISchedule filter);
        ISchedule Create(ISchedule Plan);
        void Delete(Guid Id);
        void Update(Guid Id);
        ISchedule Get(Guid Id);
    }
}
