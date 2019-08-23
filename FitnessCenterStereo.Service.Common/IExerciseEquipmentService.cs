using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
    public interface IExerciseEquipmentService
    {
        IEnumerable<IExerciseEquipment> Find(IFilter filter);
        IExerciseEquipment Create(IExerciseEquipment exerciseEquipment);
        bool Delete(Guid id);
        bool Update(IExerciseEquipment exerciseEquipment);
        IExerciseEquipment Get(Guid id);
    }
}
