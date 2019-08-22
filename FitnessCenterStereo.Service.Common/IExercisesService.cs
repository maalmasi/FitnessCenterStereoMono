using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
   public interface IExercisesService
    {
        IEnumerable<IExercisesService> Find(IFilter filter);
        IExercisesService Create(IExercisesService Exercises);
        void Delete(Guid Id);
        void Update(Guid Id);
        IExercisesService Get(Guid Id);

    }
}
