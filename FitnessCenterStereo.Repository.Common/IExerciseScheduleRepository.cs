using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IExerciseScheduleRepository
    {

        IEnumerable<IExerciseScheduleRepository> Find(IFilter filter);
        IExerciseScheduleRepository Create(IExerciseScheduleRepository ExerciseSchedule);
        void Delete(Guid Id);
        void Update(Guid Id);
        IExerciseScheduleRepository Get(Guid Id);

    }
}
