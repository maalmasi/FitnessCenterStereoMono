using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IExerciseEquipmentRepository {
        IEnumerable<IExerciseEquipmentRepository> Find(IFilter filter);
        IExerciseEquipmentRepository Create(IExerciseEquipmentRepository bodyPartType);
        bool Delete(Guid id);
        bool Update(IExerciseEquipmentRepository bodyPartType);
        IExerciseEquipmentRepository Get(Guid id);
    }
}
