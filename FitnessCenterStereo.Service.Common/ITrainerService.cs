using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
   public interface ITrainerService
    {
        IEnumerable<IBodyPartType> Find(IFilter filter);
        IBodyPartType Create(IBodyPartType trainer);
        bool Delete(Guid id);
        bool Update(IBodyPartType trainer);
        IBodyPartType Get(Guid id);
    }
}
