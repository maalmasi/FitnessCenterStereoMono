using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Service.Common
{
    public interface IExerciseEquipmentService
    {
        #region Methods

        IExerciseEquipment Create(IExerciseEquipment exerciseEquipment);

        bool Delete(Guid id);

        PaginatedList<IExerciseEquipment> Find(IFilter filter);

        IExerciseEquipment Get(Guid id);

        bool Update(IExerciseEquipment exerciseEquipment);

        #endregion Methods
    }
}