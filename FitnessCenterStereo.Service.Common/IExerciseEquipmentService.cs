using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IExerciseEquipmentService
    {
        Guid GetByExerciseEquipmentId(Guid ExerciseEquipmentId);
    }
}
