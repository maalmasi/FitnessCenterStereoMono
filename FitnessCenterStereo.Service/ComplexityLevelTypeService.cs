using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;

namespace FitnessCenterStereo.Service
{
    class ComplexityLevelTypeService : IComplexityLevelTypeService
    {
        public ComplexityLevelTypeService(IComplexityLevelTypeRepository complexityLevelTypeRepository)
        {
            ComplexityLevelTypeRepository = complexityLevelTypeRepository;
        }

        protected IComplexityLevelTypeRepository ComplexityLevelTypeRepository { get; private set; }

        public IComplexityLevelType Create(IComplexityLevelType complexityLevelType)
        {
            return ComplexityLevelTypeRepository.Create(complexityLevelType);
        }

        public bool Delete(Guid id)
        {
            if (ComplexityLevelTypeRepository.Delete(id))
                return true;
            else return false;
        }

        public IEnumerable<IComplexityLevelType> Find(IFilter filter)
        {
            return ComplexityLevelTypeRepository.Find(filter);
        }

        public IComplexityLevelType Get(Guid id)
        {
            return ComplexityLevelTypeRepository.Get(id);
        }

        public bool Update(IComplexityLevelType complexityLevelType)
        {
            if (ComplexityLevelTypeRepository.Update(complexityLevelType))
                return true;
            else return false;
        }
    }

}
