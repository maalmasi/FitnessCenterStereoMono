using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;

namespace FitnessCenterStereo.Service
{
    class TrainerService
    {
        public TrainerService(ITrainerRepository trainerRepository)
        {
            TrainerRepository = trainerRepository;
        }

        protected ITrainerRepository TrainerRepository { get; private set; }

        public IBodyPartType Create(IBodyPartType trainer)
        {
            return TrainerRepository.Create(trainer);
        }

        public bool Delete(Guid id)
        {
            if (TrainerRepository.Delete(id))
                return true;
            else return false;
        }

        public IEnumerable<IBodyPartType> Find(IFilter filter)
        {
            return TrainerRepository.Find(filter);
        }

        public IBodyPartType Get(Guid id)
        {
            return TrainerRepository.Get(id);
        }

        public bool Update(IBodyPartType trainer)
        {
            if (TrainerRepository.Update(trainer))
                return true;
            else return false;
        }

    }
}
}
