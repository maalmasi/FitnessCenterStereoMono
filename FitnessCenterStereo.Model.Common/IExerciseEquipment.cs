using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IExerciseEquipment : IBaseModel
    {
        Guid ExerciseId { get; set; }
        Guid EquipmentId { get; set; }
    }
}
