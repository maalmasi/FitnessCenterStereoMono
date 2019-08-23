using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
   public interface IExercisesService
    {
        IEnumerable<IExercises> Find(IFilter filter);
        IExercises Create(IExercises exercises);
        bool Delete(Guid id);
        bool Update(IExercises exercises);
        IExercises Get(Guid id);

    }
}
