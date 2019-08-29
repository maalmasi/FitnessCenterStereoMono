using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Service.Common
{
    public interface IPlanService
    {
        #region Methods

        IPlan Create(IPlan plan);

        bool Delete(Guid id);

        PaginatedList<IPlan> Find(IFilter filter);

        IPlan Get(Guid id);

        bool Update(IPlan plan);

        #endregion Methods
    }
}