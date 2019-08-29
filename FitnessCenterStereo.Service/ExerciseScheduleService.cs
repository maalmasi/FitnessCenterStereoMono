using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;

namespace FitnessCenterStereo.Service
{
    internal class ExerciseScheduleService : IExerciseScheduleService
    {
        #region Constructors

        public ExerciseScheduleService(IExerciseScheduleRepository exerciseScheduleRepository)
        {
            ExerciseScheduleRepository = exerciseScheduleRepository;
        }

        #endregion Constructors

        #region Properties

        protected IExerciseScheduleRepository ExerciseScheduleRepository { get; private set; }

        #endregion Properties

        #region Methods

        public IExerciseSchedule Create(IExerciseSchedule exerciseSchedule)
        {
            return ExerciseScheduleRepository.Create(exerciseSchedule);
        }

        public bool Delete(Guid id)
        {
            return ExerciseScheduleRepository.Delete(id);
        }

        public PaginatedList<IExerciseSchedule> Find(IFilter filter)
        {
            return ExerciseScheduleRepository.Find(filter);
        }

        public IExerciseSchedule Get(Guid id)
        {
            return ExerciseScheduleRepository.Get(id);
        }

        public bool Update(IExerciseSchedule exerciseSchedule)
        {
            return ExerciseScheduleRepository.Update(exerciseSchedule);
        }

        #endregion Methods
    }
}