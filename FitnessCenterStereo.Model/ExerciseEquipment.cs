using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model
{
    public class ExerciseEquipment : BaseModel, IExerciseEquipment
    {
        public Guid ExerciseId { get; set; }
        public Guid EquipmentId { get; set; }
     
    }
}
