using FitnessCenterStereo.Model.Common;
using System;

namespace FitnessCenterStereo.Model
{
    public class ExerciseSchedule : BaseModel, IExerciseSchedule
    {
        #region Properties

        public Guid ExerciseId { get; set; }
        public Guid ScheduleId { get; set; }

        #endregion Properties
    }
}