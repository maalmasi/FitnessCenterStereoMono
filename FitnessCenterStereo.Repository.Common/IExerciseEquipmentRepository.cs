using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IExerciseEquipmentRepository {

        IEnumerable<IExerciseEquipmentRepository> Find(IFilter filter);
        IExerciseEquipmentRepository Create(IExerciseEquipmentRepository ExerciseEquipment);
        void Delete(Guid Id);
        void Update(Guid Id);
        IExerciseEquipmentRepository Get(Guid Id);
    }
}
