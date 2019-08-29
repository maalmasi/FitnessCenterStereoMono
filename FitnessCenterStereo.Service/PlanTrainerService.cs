using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;

namespace FitnessCenterStereo.Service
{
    internal class PlanTrainerService : IPlanTrainerService
    {
        #region Constructors

        public PlanTrainerService(IPlanTrainerRepository planTrainerRepository)
        {
            PlanTrainerRepository = planTrainerRepository;
        }

        #endregion Constructors

        #region Properties

        protected IPlanTrainerRepository PlanTrainerRepository { get; private set; }

        #endregion Properties

        #region Methods

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

        #endregion Methods
    }
}