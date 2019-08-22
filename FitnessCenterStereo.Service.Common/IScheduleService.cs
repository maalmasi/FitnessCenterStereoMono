using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
    public interface IScheduleService
    {
        IEnumerable<IScheduleService> Find(IScheduleService filter);
        IScheduleService Create(IScheduleService Plan);
        void Delete(Guid Id);
        void Update(Guid Id);
        IScheduleService Get(Guid Id);
    }
}
