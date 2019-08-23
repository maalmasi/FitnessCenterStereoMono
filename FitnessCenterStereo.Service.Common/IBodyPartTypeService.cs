using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
    public interface IBodyPartTypeService
    {
        IEnumerable<IBodyPartType> Find(IFilter filter);
        IBodyPartType Create(IBodyPartType bodyPartType);
        bool Delete(Guid id);
        bool Update(IBodyPartType bodyPartType);
        IBodyPartType Get(Guid id);

    }
}
