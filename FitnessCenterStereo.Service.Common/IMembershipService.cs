using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Service.Common
{
    public interface IMembershipService
    {
        #region Methods

        IMembership Create(IMembership membership);

        bool Delete(Guid id);

        PaginatedList<IMembership> Find(IFilter filter);

        IMembership Get(Guid id);

        bool Update(IMembership membership);

        #endregion Methods
    }
}