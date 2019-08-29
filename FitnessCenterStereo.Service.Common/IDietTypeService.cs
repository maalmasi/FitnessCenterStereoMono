using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Service.Common
{
    public interface IDietTypeService
    {
        #region Methods

        IDietType Create(IDietType dietType);

        bool Delete(Guid id);

        PaginatedList<IDietType> Find(IDietTypeFilter filter);

        IDietType Get(Guid id);

        bool Update(IDietType dietType);

        #endregion Methods
    }
}