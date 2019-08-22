using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
   public interface IPlanService
    {
        IEnumerable<IPlanService> Find(IFilter filter);
        IPlanService Create(IPlanService Plan);
        void Delete(Guid Id);
        void Update(Guid Id);
        IPlanService Get(Guid Id);
    }
}
