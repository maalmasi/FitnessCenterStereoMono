using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IExerciseScheduleRepository
    {

        IEnumerable<IExerciseSchedule> Find(IFilter filter);
        IExerciseSchedule Create(IExerciseSchedule ExerciseSchedule);
        void Delete(Guid Id);
        void Update(Guid Id);
        IExerciseSchedule Get(Guid Id);

    }
}
