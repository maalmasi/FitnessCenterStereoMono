using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;

namespace FitnessCenterStereo.Service
{
    class ExercisesService : IExercisesService
    {
      protected  IExercisesRepository ExercisesRepository { get; private set; }

        public ExercisesService(IExercisesRepository exercisesRepository)
        {
            ExercisesRepository = exercisesRepository;
        }
        public IExercises Create(IExercises exercises)
        {
            return ExercisesRepository.Create(exercises);
        }

        public bool Delete(Guid id)
        {
            return ExercisesRepository.Delete(id);
        }

        public PaginatedList<IExercises> Find(IFilter filter)
        {
            return ExercisesRepository.Find(filter);
        }

        public IExercises Get(Guid id)
        {
            return ExercisesRepository.Get(id);
        }

        public bool Update(IExercises exercises)
        {
            return ExercisesRepository.Update(exercises);
        }
    }
}
