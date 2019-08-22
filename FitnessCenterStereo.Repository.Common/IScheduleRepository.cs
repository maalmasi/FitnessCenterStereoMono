using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IScheduleRepository
    {
        IEnumerable<ISchedule> Find(IFilter filter);
        ISchedule Create(ISchedule Schedule);
        void Delete(Guid Id);
        void Update(Guid Id);
        ISchedule Get(Guid Id);

    }
}
