using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IStepRepository
    {
        #region Methods

        IStep Create(IStep step);

        bool Delete(Guid id);

        PaginatedList<IStep> Find(IFilter filter);

        IStep Get(Guid id);

        bool Update(IStep step);

        #endregion Methods
    }
}