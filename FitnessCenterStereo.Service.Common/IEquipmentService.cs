using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Service.Common
{
    public interface IEquipmentService
    {
        #region Methods

        IEquipment Create(IEquipment equipment);

        bool Delete(Guid id);

        PaginatedList<IEquipment> Find(IEquipmentFilter filter);

        IEquipment Get(Guid id);

        bool Update(IEquipment equipment);

        #endregion Methods
    }
}