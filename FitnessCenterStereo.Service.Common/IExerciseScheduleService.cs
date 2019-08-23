using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
    public interface IExerciseScheduleService
    {
        IEnumerable<IExerciseSchedule> Find(IFilter filter);
        IExerciseSchedule Create(IExerciseSchedule exerciseSchedule);
        bool Delete(Guid id);
        bool Update(IExerciseSchedule exerciseSchedule);
        IExerciseSchedule Get(Guid id);
    }
}
