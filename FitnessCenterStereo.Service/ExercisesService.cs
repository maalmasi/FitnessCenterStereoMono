using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;

namespace FitnessCenterStereo.Service
{
    class ExercisesService
    {
        public ExercisesService(IBodyPartTypeRepository exerciseRepository)
        {
            ExerciseseRepository = exerciseRepository;
        }

        protected IBodyPartTypeRepository ExerciseseRepository { get; private set; }

        public IExercises Create(IExercises exercises)
        {
            return ExerciseseRepository.Create(exercises);
        }

        public bool Delete(Guid id)
        {
            if (ExerciseseRepository.Delete(id))
                return true;
            else return false;
        }

        public IEnumerable<IExercises> Find(IFilter filter)
        {
            return ExerciseseRepository.Find(filter);
        }

        public IExercises Get(Guid id)
        {
            return ExerciseseRepository.Get(id);
        }

        public bool Update(IExercises exercises)
        {
            if (ExerciseseRepository.Update(exercises))
                return true;
            else return false;
        }

    }
}
}
