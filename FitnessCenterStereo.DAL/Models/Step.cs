using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Step
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Abbreaviaton { get; set; }
        public string Description { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public Guid? ExercisesId { get; set; }

        public virtual Exercises Exercises { get; set; }
    }
}
