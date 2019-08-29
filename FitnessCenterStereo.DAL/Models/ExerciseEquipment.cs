﻿using System;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class ExerciseEquipment
    {
        #region Properties

        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public virtual Equipment Equipment { get; set; }
        public Guid? EquipmentId { get; set; }
        public virtual Exercises Exercises { get; set; }
        public Guid? ExercisesId { get; set; }
        public Guid Id { get; set; }

        #endregion Properties
    }
}