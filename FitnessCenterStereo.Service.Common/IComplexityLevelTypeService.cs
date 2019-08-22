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
        IComplexityLevelType Create(IComplexityLevelType ComplexityLevel);
        void Delete(Guid Id);
        void Update(Guid Id);
        IComplexityLevelType Get(Guid Id);
    }
}
