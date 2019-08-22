using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IScheduleRepository
    {
        IEnumerable<IScheduleRepository> Find(IFilter filter);
        IScheduleRepository Create(IScheduleRepository Schedule);
        void Delete(Guid Id);
        void Update(Guid Id);
        IScheduleRepository Get(Guid Id);

    }
}
