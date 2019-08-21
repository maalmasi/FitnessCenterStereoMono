using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Schedule
    {
        public Schedule()
        {
            ExerciseSchedule = new HashSet<ExerciseSchedule>();
        }

        public Guid Id { get; set; }
        public int? Frequency { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public Guid? PlanId { get; set; }

        public virtual Plan Plan { get; set; }
        public virtual ICollection<ExerciseSchedule> ExerciseSchedule { get; set; }
    }
}
