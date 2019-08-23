using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IComplexityLevelTypeRepository
    {
        IEnumerable<IComplexityLevelTypeRepository> Find(IFilter filter);
        IComplexityLevelTypeRepository Create(IComplexityLevelTypeRepository bodyPartType);
        bool Delete(Guid id);
        bool Update(IComplexityLevelTypeRepository bodyPartType);
        IComplexityLevelTypeRepository Get(Guid id);

    }
}
