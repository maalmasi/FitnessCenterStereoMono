using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IComplexityLevelTypeRepository
    {
        IEnumerable<IComplexityLevelType> Find(IFilter filter);
        IComplexityLevelTypeRepository Create(IComplexityLevelType ComplexityLevelType);
        void Delete(Guid Id);
        void Update(Guid Id);
        IComplexityLevelType Get(Guid Id);

    }
}
