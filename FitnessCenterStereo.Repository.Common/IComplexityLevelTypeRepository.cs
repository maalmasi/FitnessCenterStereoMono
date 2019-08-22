using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IComplexityLevelTypeRepository
    {
        IEnumerable<IComplexityLevelTypeRepository> Find(IFilter filter);
        IComplexityLevelTypeRepository Create(IComplexityLevelTypeRepository ComplexityLevelType);
        void Delete(Guid Id);
        void Update(Guid Id);
        IComplexityLevelTypeRepository Get(Guid Id);

    }
}
