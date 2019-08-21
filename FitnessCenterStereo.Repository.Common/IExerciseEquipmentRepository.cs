using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IExerciseEquipmentRepository {

        Guid GetByExerciseEquipmentId(Guid ExerciseEquipmentId);
    }
}
