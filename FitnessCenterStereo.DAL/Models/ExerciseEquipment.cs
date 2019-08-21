using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class ExerciseEquipment
    {
        public Guid? ExercisesId { get; set; }
        public Guid? EquipmentId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public Guid Id { get; set; }

        public virtual Equipment Equipment { get; set; }
        public virtual Exercises Exercises { get; set; }
    }
}
