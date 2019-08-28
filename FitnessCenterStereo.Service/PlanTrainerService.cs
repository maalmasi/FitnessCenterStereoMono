using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;

namespace FitnessCenterStereo.Service
{
    class PlanTrainerService : IPlanTrainerService
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
                return PlanTrainerRepository.Delete(id);
        }

        public PaginatedList<IPlanTrainer> Find(IFilter filter)
        {
            return PlanTrainerRepository.Find(filter);
        }

        public IPlanTrainer Get(Guid id)
        {
            return PlanTrainerRepository.Get(id);
        }

        public bool Update(IPlanTrainer planTrainer)
        {
            return PlanTrainerRepository.Update(planTrainer);
        }
    }

}
