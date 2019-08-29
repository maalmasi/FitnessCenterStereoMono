using System;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class ExerciseSchedule
    {
        #region Properties

        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public virtual Exercises Exercises { get; set; }
        public Guid? ExercisesId { get; set; }
        public Guid Id { get; set; }
        public virtual Schedule Schedule { get; set; }
        public Guid? ScheduleId { get; set; }

        #endregion Properties
    }
}