using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Schedule
    {
        #region Constructors

        public Schedule()
        {
            ExerciseSchedule = new HashSet<ExerciseSchedule>();
        }

        #endregion Constructors

        #region Properties

        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public virtual ICollection<ExerciseSchedule> ExerciseSchedule { get; set; }
        public int? Frequency { get; set; }
        public Guid Id { get; set; }
        public virtual Plan Plan { get; set; }
        public Guid? PlanId { get; set; }

        #endregion Properties
    }
}