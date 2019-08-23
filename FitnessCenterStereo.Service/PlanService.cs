using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;

namespace FitnessCenterStereo.Service
{
    class PlanService
    {
        public PlanService(IBodyPartTypeRepository planRepository)
        {
            PlanRepository = planRepository;
        }

        protected IBodyPartTypeRepository PlanRepository { get; private set; }

        public IPlan Create(IPlan plan)
        {
            return PlanRepository.Create(plan);
        }

        public bool Delete(Guid id)
        {
            if (PlanRepository.Delete(id))
                return true;
            else return false;
        }

        public IEnumerable<IPlan> Find(IFilter filter)
        {
            return PlanRepository.Find(filter);
        }

        public IPlan Get(Guid id)
        {
            return PlanRepository.Get(id);
        }

        public bool Update(IPlan plan)
        {
            if (PlanRepository.Update(plan))
                return true;
            else return false;
        }

    }
}
}
