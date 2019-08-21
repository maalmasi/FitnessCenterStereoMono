using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Exercises
    {
        public Exercises()
        {
            ExerciseEquipment = new HashSet<ExerciseEquipment>();
            ExerciseSchedule = new HashSet<ExerciseSchedule>();
            Step = new HashSet<Step>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public Guid? BodyPartId { get; set; }
        public Guid? ComplexityLeveTypelId { get; set; }

        public virtual BodyPartType BodyPart { get; set; }
        public virtual ComplexityLevelType ComplexityLeveTypel { get; set; }
        public virtual ICollection<ExerciseEquipment> ExerciseEquipment { get; set; }
        public virtual ICollection<ExerciseSchedule> ExerciseSchedule { get; set; }
        public virtual ICollection<Step> Step { get; set; }
    }
}
