using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;

namespace FitnessCenterStereo.Service
{
    class StepService : IStepService
    {
        public StepService(IStepRepository stepRepository)
        {
            StepRepository = stepRepository;
        }

        public IStepRepository StepRepository { get; }

        public IStep Create(IStep step)
        {
            return StepRepository.Create(step);
        }

        public bool Delete(Guid id)
        {
            if (StepRepository.Delete(id))
                return true;
            else return false;
        }

        public IEnumerable<IStep> Find(IFilter filter)
        {
            return StepRepository.Find(filter);
        }

        public IStep Get(Guid id)
        {
            return StepRepository.Get(id);
        }

        public bool Update(IStep step)
        {
            if (StepRepository.Update(step))
                return true;
            else return false;
        }

    }
}
