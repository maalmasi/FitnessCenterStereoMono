using System;

namespace FitnessCenterStereo.WebApi.Models
{
    public class ExerciseScheduleViewModel : BaseViewModel
    {
        #region Properties

        public Guid ExerciseId { get; set; }
        public Guid ScheduleId { get; set; }

        #endregion Properties
    }
}