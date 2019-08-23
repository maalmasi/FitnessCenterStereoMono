using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;

namespace FitnessCenterStereo.Service
{
    class ExercisesService : IExercisesService
    {
        public ExercisesService(IExercisesRepository exercisesRepository)
        {
            ExercisesesRepository = exercisesRepository;
        }

        protected IExercisesRepository ExercisesesRepository { get; private set; }

        public IExercises Create(IExercises exercises)
        {
            return ExercisesesRepository.Create(exercises);
        }

        public bool Delete(Guid id)
        {
            if (ExercisesesRepository.Delete(id))
                return true;
            else return false;
        }

        public IEnumerable<IExercises> Find(IFilter filter)
        {
            return ExercisesesRepository.Find(filter);
        }

        public IExercises Get(Guid id)
        {
            return ExercisesesRepository.Get(id);
        }

        public bool Update(IExercises exercises)
        {
            if (ExercisesesRepository.Update(exercises))
                return true;
            else return false;
        }

    }
}
