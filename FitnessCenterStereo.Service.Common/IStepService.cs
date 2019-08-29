using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Service.Common
{
    public interface IStepService
    {
        #region Methods

        IStep Create(IStep step);

        bool Delete(Guid id);

        PaginatedList<IStep> Find(IStepFilter filter);

        IStep Get(Guid id);

        bool Update(IStep step);

        #endregion Methods
    }
}