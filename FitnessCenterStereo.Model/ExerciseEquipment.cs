using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model
{
    public class ExerciseEquipment : IBaseModel, IExerciseEquipment
    {
        public Guid ExerciseId { get; set; }
        public Guid EquipmentId { get; set; }
        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        public Guid ExerciseEquipmentId { get; set; }
        public Guid Id { get; set; }
    }
}
