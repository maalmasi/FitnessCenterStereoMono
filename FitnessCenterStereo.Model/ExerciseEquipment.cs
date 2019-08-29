using FitnessCenterStereo.Model.Common;
using System;

namespace FitnessCenterStereo.Model
{
    public class ExerciseEquipment : BaseModel, IExerciseEquipment
    {
        #region Properties

        public Guid EquipmentId { get; set; }
        public Guid ExerciseId { get; set; }

        #endregion Properties
    }
}