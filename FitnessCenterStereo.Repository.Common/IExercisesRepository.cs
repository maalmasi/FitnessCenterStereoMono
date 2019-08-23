using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
   public interface IExercisesRepository
    {
        IEnumerable<IExercisesRepository> Find(IFilter filter);
        IExercisesRepository Create(IExercisesRepository bodyPartType);
        bool Delete(Guid id);
        bool Update(IExercisesRepository bodyPartType);
        IExercisesRepository Get(Guid id);


    }
}
