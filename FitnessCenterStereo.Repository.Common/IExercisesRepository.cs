using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
   public interface IExercisesRepository
    {
        IEnumerable<IExercises> Find(IFilter filter);
        IExercises Create(IExercises ExerciseSchedule);
        void Delete(Guid Id);
        void Update(Guid Id);
        IExercises Get(Guid Id);


    }
}
