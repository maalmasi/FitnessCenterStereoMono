using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Service.Common
{
    public interface IComplexityLevelTypeService
    {
        #region Methods

        IComplexityLevelType Create(IComplexityLevelType complexityLevel);

        bool Delete(Guid id);

        PaginatedList<IComplexityLevelType> Find(IFilter filter);

        IComplexityLevelType Get(Guid id);

        bool Update(IComplexityLevelType complexityLevel);

        #endregion Methods
    }
}