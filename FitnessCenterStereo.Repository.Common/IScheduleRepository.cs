using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IScheduleRepository
    {
        IEnumerable<IScheduleRepository> Find(IFilter filter);
        IScheduleRepository Create(IScheduleRepository bodyPartType);
        bool Delete(Guid id);
        bool Update(IScheduleRepository bodyPartType);
        IScheduleRepository Get(Guid id);
    }
}
