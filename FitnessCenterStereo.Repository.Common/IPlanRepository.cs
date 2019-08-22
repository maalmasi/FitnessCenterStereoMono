using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
   public interface IPlanRepository
    {
        IEnumerable<IPlanRepository> Find(IFilter filter);
        IPlanRepository Create(IPlanRepository Plan);
        void Delete(Guid Id);
        void Update(Guid Id);
        IPlanRepository Get(Guid Id);

    }
}
