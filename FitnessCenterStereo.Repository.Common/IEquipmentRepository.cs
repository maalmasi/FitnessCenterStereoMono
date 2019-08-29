using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IEquipmentRepository
    {
        #region Methods

        IEquipment Create(IEquipment equipment);

        bool Delete(Guid id);

        PaginatedList<IEquipment> Find(IFilter filter);

        IEquipment Get(Guid id);

        bool Update(IEquipment bodyPartType);

        #endregion Methods
    }
}