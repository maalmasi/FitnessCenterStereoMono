using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IComplexityLevelTypeRepository
    {
        IEnumerable<IComplexityLevelType> Find(IFilter filter);
        IComplexityLevelType Create(IComplexityLevelType complexity);
        bool Delete(Guid id);
        bool Update(IComplexityLevelType complexity);
        IComplexityLevelType Get(Guid id);

    }
}
