using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
    public interface IComplexityLevelTypeService
    {
        IEnumerable<IComplexityLevelType> Find(IFilter filter);
        IComplexityLevelType Create(IComplexityLevelType complexityLevelType);
        bool Delete(Guid id);
        bool Update(IComplexityLevelType complexityLevelType);
        IComplexityLevelType Get(Guid id);
    }
}
