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
    class ExerciseScheduleService : IExerciseScheduleService
    {
        public ExerciseScheduleService(IExerciseScheduleRepository exerciseScheduleRepository)
        {
            ExerciseScheduleRepository = exerciseScheduleRepository;
        }

        protected IExerciseScheduleRepository ExerciseScheduleRepository { get; private set; }

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

    }

}
