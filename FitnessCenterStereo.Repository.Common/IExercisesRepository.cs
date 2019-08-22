using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
   public interface IExercisesRepository
    {
        IEnumerable<IExercisesRepository> Find(IFilter filter);
        IExercisesRepository Create(IExercisesRepository ExerciseSchedule);
        void Delete(Guid Id);
        void Update(Guid Id);
        IExercisesRepository Get(Guid Id);


    }
}
