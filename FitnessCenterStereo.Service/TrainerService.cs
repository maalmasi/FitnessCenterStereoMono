using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;

namespace FitnessCenterStereo.Service
{
    internal class TrainerService : ITrainerService
    {
        #region Constructors

        public TrainerService(ITrainerRepository trainerRepository)
        {
            TrainerRepository = trainerRepository;
        }

        #endregion Constructors

        #region Properties

        protected ITrainerRepository TrainerRepository { get; private set; }

        #endregion Properties

        #region Methods

        public ITrainer Create(ITrainer trainer)
        {
            return TrainerRepository.Create(trainer);
        }

        public bool Delete(Guid id)
        {
            return TrainerRepository.Delete(id);
        }

        public PaginatedList<ITrainer> Find(IFilter filter)
        {
            return TrainerRepository.Find(filter);
        }

        public ITrainer Get(Guid id)
        {
            return TrainerRepository.Get(id);
        }

        public bool Update(ITrainer trainer)
        {
            return TrainerRepository.Update(trainer);
        }

        #endregion Methods
    }
}