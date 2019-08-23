using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;

namespace FitnessCenterStereo.Service
{
    class TrainerService : ITrainerService
    {
        public TrainerService(ITrainerRepository trainerRepository)
        {
            TrainerRepository = trainerRepository;
        }

        protected ITrainerRepository TrainerRepository { get; private set; }

        public ITrainer Create(ITrainer trainer)
        {
            return TrainerRepository.Create(trainer);
        }

        public bool Delete(Guid id)
        {
            if (TrainerRepository.Delete(id))
                return true;
            else return false;
        }

        public IEnumerable<ITrainer> Find(IFilter filter)
        {
            return TrainerRepository.Find(filter);
        }

        public ITrainer Get(Guid id)
        {
            return TrainerRepository.Get(id);
        }

        public bool Update(ITrainer trainer)
        {
            if (TrainerRepository.Update(trainer))
                return true;
            else return false;
        }

    }
}
