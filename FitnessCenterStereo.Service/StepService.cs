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
    class StepService : IStepService
    {

        protected IStepRepository StepRepository { get; private set; }
        
        public StepService(IStepRepository stepRepository)
        {
            StepRepository = stepRepository;
        }
        public IStep Create(IStep step)
        {
            return StepRepository.Create(step);
        }

        public bool Delete(Guid id)
        {
            return StepRepository.Delete(id);
        }

        public PaginatedList<IStep> Find(IFilter filter)
        {
            return StepRepository.Find(filter);
        }

        public IStep Get(Guid id)
        {
            return StepRepository.Get(id);
        }

        public bool Update(IStep step)
        {
            return StepRepository.Update(step);
        }
    }
}
