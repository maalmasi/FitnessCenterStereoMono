using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IPlanRepository
    {
        #region Methods

        IPlan Create(IPlan planTrainer);

        bool Delete(Guid id);

        PaginatedList<IPlan> Find(IFilter filter);

        IPlan Get(Guid id);

        bool Update(IPlan planTrainer);

        #endregion Methods
    }
}