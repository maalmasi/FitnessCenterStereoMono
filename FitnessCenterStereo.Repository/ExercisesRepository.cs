using FitnessCenterStereo.Common;
using FitnessCenterStereo.Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository
{

    class ExercisesRepository : IExercisesRepository
    {
        public IExercisesRepository Create(IExercisesRepository bodyPartType)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IExercisesRepository> Find(IFilter filter)
        {
            throw new NotImplementedException();
        }

        public IExercisesRepository Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(IExercisesRepository bodyPartType)
        {
            throw new NotImplementedException();
        }
    }
}
