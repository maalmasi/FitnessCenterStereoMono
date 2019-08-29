using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;

namespace FitnessCenterStereo.Service
{
    internal class StepService : IStepService
    {
        #region Constructors

        public StepService(IStepRepository stepRepository)
        {
            StepRepository = stepRepository;
        }

        #endregion Constructors

        #region Properties

        protected IStepRepository StepRepository { get; private set; }

        #endregion Properties

        #region Methods

        public IStep Create(IStep step)
        {
            return StepRepository.Create(step);
        }

        public bool Delete(Guid id)
        {
            return StepRepository.Delete(id);
        }

        public PaginatedList<IStep> Find(IStepFilter filter)
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

        #endregion Methods
    }
}