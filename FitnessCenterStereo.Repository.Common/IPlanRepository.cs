using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
   public interface IPlanRepository
    {
        IEnumerable<IPlanRepository> Find(IFilter filter);
        IPlanRepository Create(IPlanRepository bodyPartType);
        bool Delete(Guid id);
        bool Update(IPlanRepository bodyPartType);
        IPlanRepository Get(Guid id);

    }
}
