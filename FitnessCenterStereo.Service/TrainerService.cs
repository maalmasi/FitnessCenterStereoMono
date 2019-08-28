using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using AutoMapper;

namespace FitnessCenterStereo.Service
{

    class TrainerService : ITrainerService
    {
        protected ITrainerRepository TrainerRepository { get; private set; }


        public TrainerService(ITrainerRepository trainerRepository)
        {
            TrainerRepository = trainerRepository;

        }
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

        public bool Update(ITrainer trainer)
        {
            return TrainerRepository.Update(trainer);
        }

        public ITrainer Get(Guid id)
        {
            return TrainerRepository.Get(id);
        }
    }

}

