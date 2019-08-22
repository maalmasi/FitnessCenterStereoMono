using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
   public interface IPlanRepository
    {
        IEnumerable<IPlan> Find(IFilter filter);
        IPlan Create(IPlan Plan);
        void Delete(Guid Id);
        void Update(Guid Id);
        IPlan Get(Guid Id);

    }
}
