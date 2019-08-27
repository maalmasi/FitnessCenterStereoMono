using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
    public interface IComplexityLevelTypeService
    {
        PaginatedList<IComplexityLevelType> Find(IFilter filter);
        IComplexityLevelType Create(IComplexityLevelType complexityLevel);
        bool Delete(Guid id);
        bool Update(IComplexityLevelType complexityLevel);
        IComplexityLevelType Get(Guid id);
    }
}
