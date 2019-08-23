using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;

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
            if (ExerciseScheduleRepository.Delete(id))
                return true;
            else return false;
        }

        public IEnumerable<IExerciseSchedule> Find(IFilter filter)
        {
            return ExerciseScheduleRepository.Find(filter);
        }

        public IExerciseSchedule Get(Guid id)
        {
            return ExerciseScheduleRepository.Get(id);
        }

        public bool Update(IExerciseSchedule exerciseSchedule)
        {
            if (ExerciseScheduleRepository.Update(exerciseSchedule))
                return true;
            else return false;
        }

    }

}
