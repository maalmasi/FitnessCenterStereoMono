using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
    public interface IMemebershipService
    {
        IEnumerable<IBodyPartType> Find(IFilter filter);
        IBodyPartType Create(IBodyPartType memebership);
        bool Delete(Guid id);
        bool Update(IBodyPartType memebership);
        IBodyPartType Get(Guid id);
    }
}
