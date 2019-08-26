using AutoMapper;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.DAL.Data;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository
{
    class ComplexityLevelTypeRepository : IComplexityLevelTypeRepository
    {
        protected ApplicationDbContext appDbContext { get; private set; }
        private readonly IMapper mapper;
        public ComplexityLevelTypeRepository(ApplicationDbContext applicationDbContext,IMapper mapper)
        {
            appDbContext = applicationDbContext;
            this.mapper = mapper;
        }

        public IEnumerable<IComplexityLevelType> Find(IFilter filter)
        {
            return (IEnumerable<IComplexityLevelType>)appDbContext.ComplexityLevelType.Find(filter);

        }

        public IComplexityLevelType Create(IComplexityLevelType complexityLevel)
        {
            return mapper.Map<IComplexityLevelType>(appDbContext.ComplexityLevelType.Add(mapper.Map<ComplexityLevelType>(complexityLevel)));
        }

        public bool Delete(Guid id)
        {
            ComplexityLevelType ToDelete = appDbContext.ComplexityLevelType.Find(id);
            if (ToDelete != null) { appDbContext.ComplexityLevelType.Remove(ToDelete); return true; }

            return false;
        }

        public bool Update(IComplexityLevelType complexityLevel)
        {
            ComplexityLevelType ToUpdate = appDbContext.ComplexityLevelType.Find(complexityLevel);
            appDbContext.ComplexityLevelType.Update(ToUpdate);
            if (ToUpdate != complexityLevel) { return true; }

            return false;
        }

        public IComplexityLevelType Get(Guid id)
        {
            return mapper.Map<IComplexityLevelType>(appDbContext.ComplexityLevelType.Find(id));
        }
    }
}
