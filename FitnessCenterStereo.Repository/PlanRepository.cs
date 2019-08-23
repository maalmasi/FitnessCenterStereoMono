using FitnessCenterStereo.Common;
using FitnessCenterStereo.Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository
{
    class PlanRepository : IPlanRepository
    {
        public IPlanRepository Create(IPlanRepository bodyPartType)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPlanRepository> Find(IFilter filter)
        {
            throw new NotImplementedException();
        }

        public IPlanRepository Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(IPlanRepository bodyPartType)
        {
            throw new NotImplementedException();
        }
    }
}
