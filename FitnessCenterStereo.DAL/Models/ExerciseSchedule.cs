using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class ExerciseSchedule
    {
        public Guid? ScheduleId { get; set; }
        public Guid? ExercisesId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public Guid Id { get; set; }

        public virtual Exercises Exercises { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}
