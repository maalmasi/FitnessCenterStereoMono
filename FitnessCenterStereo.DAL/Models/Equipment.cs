using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Equipment
    {
        #region Constructors

        public Equipment()
        {
            ExerciseEquipment = new HashSet<ExerciseEquipment>();
        }

        #endregion Constructors

        #region Properties

        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public virtual ICollection<ExerciseEquipment> ExerciseEquipment { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }

        #endregion Properties
    }
}