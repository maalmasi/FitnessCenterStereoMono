using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;

namespace FitnessCenterStereo.Service
{
    internal class ExercisesService : IExercisesService
    {
        #region Constructors

        public ExercisesService(IExercisesRepository exercisesRepository)
        {
            ExercisesRepository = exercisesRepository;
        }

        #endregion Constructors

        #region Properties

        protected IExercisesRepository ExercisesRepository { get; private set; }

        #endregion Properties

        #region Methods

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

        #endregion Methods
    }
}