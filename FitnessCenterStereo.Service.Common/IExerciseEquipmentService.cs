using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IExerciseEquipmentService
    {
        IEnumerable<IExerciseEquipmentService> Find(IFilter filter);
        IExerciseEquipmentService Create(IExerciseEquipmentService ExerciseEquipment);
        void Delete(Guid Id);
        void Update(Guid Id);
        IExerciseEquipmentService Get(Guid Id);
    }
}
