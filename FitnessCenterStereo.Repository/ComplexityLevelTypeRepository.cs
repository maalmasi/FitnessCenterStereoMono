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
        public ComplexityLevelTypeRepository(ApplicationDbContext applicationDbContext)
        {
            appDbContext = applicationDbContext;

        }

        public IEnumerable<IComplexityLevelType> Find(IFilter filter)
        {
            return (IEnumerable<IComplexityLevelType>)appDbContext.ComplexityLevelType.Find(filter);
        }

        public IComplexityLevelType Create(IComplexityLevelType complexityLevel)
        {
            return (IComplexityLevelType)appDbContext.ComplexityLevelType.Add(new ComplexityLevelType());
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
            IComplexityLevelType complexityLevel = (IComplexityLevelType)appDbContext.ComplexityLevelType.Find(id);
            return complexityLevel;
        }
    }
}
