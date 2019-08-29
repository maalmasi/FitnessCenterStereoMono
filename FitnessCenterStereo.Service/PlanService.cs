using AutoMapper;
using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;

namespace FitnessCenterStereo.Service
{
    internal class PlanService : IPlanService
    {
        #region Fields

        private readonly IMapper Mapper;

        #endregion Fields

        #region Constructors

        public PlanService(IPlanRepository planRepository, IMapper mapper)
        {
            PlanRepository = planRepository;
            Mapper = mapper;
        }

        #endregion Constructors

        #region Properties

        protected IPlanRepository PlanRepository { get; private set; }

        #endregion Properties

        #region Methods

        public IPlan Create(IPlan plan)
        {
            return PlanRepository.Create(plan);
        }

        public bool Delete(Guid id)
        {
            return PlanRepository.Delete(id);
        }

        public PaginatedList<IPlan> Find(IPlanFilter filter)
        {
            return PlanRepository.Find(filter);
        }

        public IPlan Get(Guid id)
        {
            return PlanRepository.Get(id);
        }

        public bool Update(IPlan plan)
        {
            return PlanRepository.Update(plan);
        }

        #endregion Methods
    }
}