using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IExerciseEquipmentRepository {
        PaginatedList<IExerciseEquipment> Find(IFilter filter);
        IExerciseEquipment Create(IExerciseEquipment exerciseEquipment);
        bool Delete(Guid id);
        bool Update(IExerciseEquipment exerciseEquipment);
        IExerciseEquipment Get(Guid id);
    }
}
