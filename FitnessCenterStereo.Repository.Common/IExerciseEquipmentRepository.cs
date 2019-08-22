using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IExerciseEquipmentRepository {

        IEnumerable<IExerciseEquipment> Find(IFilter filter);
        IExerciseEquipment Create(IExerciseEquipment ExerciseEquipment);
        void Delete(Guid Id);
        void Update(Guid Id);
        IExerciseEquipment Get(Guid Id);
    }
}
