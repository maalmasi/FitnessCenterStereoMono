using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IComplexityLevelTypeService
    {
        IEnumerable<IComplexityLevelTypeService> Find(IFilter filter);
        IComplexityLevelTypeService Create(IComplexityLevelTypeService ComplexityLevel);
        void Delete(Guid Id);
        void Update(Guid Id);
        IComplexityLevelTypeService Get(Guid Id);
    }
}
