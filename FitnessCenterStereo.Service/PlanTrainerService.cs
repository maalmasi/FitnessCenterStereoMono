using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;

namespace FitnessCenterStereo.Service
{
    class PlanTrainerService
    {
        public PlanTrainerService(IPlanTrainerRepository planTrainerRepository)
        {
            PlanTrainerRepository = planTrainerRepository;
        }

        protected IPlanTrainerRepository PlanTrainerRepository { get; private set; }

        public IPlanTrainer Create(IPlanTrainer planTrainer)
        {
            return PlanTrainerRepository.Create(planTrainer);
        }

        public bool Delete(Guid id)
        {
            if (PlanTrainerRepository.Delete(id))
                return true;
            else return false;
        }

        public IEnumerable<IPlanTrainer> Find(IFilter filter)
        {
            return PlanTrainerRepository.Find(filter);
        }

        public IPlanTrainer Get(Guid id)
        {
            return PlanTrainerRepository.Get(id);
        }

        public bool Update(IPlanTrainer planTrainer)
        {
            if (PlanTrainerRepository.Update(planTrainer))
                return true;
            else return false;
        }

    }

}
