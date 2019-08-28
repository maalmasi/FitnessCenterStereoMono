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
    class PlanService : IPlanService
    {
       protected IPlanRepository PlanRepository { get; private set; }
        private readonly IMapper Mapper;

        public PlanService(IPlanRepository planRepository, IMapper mapper)
        {
            PlanRepository = planRepository;
            Mapper = mapper;
        }

        public IPlan Create(IPlan plan)
        {
            return PlanRepository.Create(plan);
        }

        public bool Delete(Guid id)
        {
            return PlanRepository.Delete(id);
        }

        public PaginatedList<IPlan> Find(IFilter filter)
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
    }
}
