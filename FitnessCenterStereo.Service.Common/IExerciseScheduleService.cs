using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IExerciseScheduleService
    {
        IEnumerable<IExerciseScheduleService> Find(IFilter filter);
        IExerciseScheduleService Create(IExerciseScheduleService ExerciseSchedule);
        void Delete(Guid Id);
        void Update(Guid Id);
        IExerciseScheduleService Get(Guid Id);
    }
}
