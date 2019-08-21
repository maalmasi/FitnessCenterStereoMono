using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            ExerciseEquipment = new HashSet<ExerciseEquipment>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual ICollection<ExerciseEquipment> ExerciseEquipment { get; set; }
    }
}
