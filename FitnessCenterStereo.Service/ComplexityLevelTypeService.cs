using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;

namespace FitnessCenterStereo.Service
{
    internal class ComplexityLevelTypeService : IComplexityLevelTypeService
    {
        #region Constructors

        public ComplexityLevelTypeService(IComplexityLevelTypeRepository complexityLevelTypeRepository)
        {
            ComplexityLevelTypeRepository = complexityLevelTypeRepository;
        }

        #endregion Constructors

        #region Properties

        protected IComplexityLevelTypeRepository ComplexityLevelTypeRepository { get; private set; }

        #endregion Properties

        #region Methods

        public IComplexityLevelType Create(IComplexityLevelType complexityLevel)
        {
            return ComplexityLevelTypeRepository.Create(complexityLevel);
        }

        public bool Delete(Guid id)
        {
            if (ComplexityLevelTypeRepository.Delete(id))
                return true;
            else return false;
        }

        public PaginatedList<IComplexityLevelType> Find(IComplexityLevelTypeFilter filter)
        {
            return ComplexityLevelTypeRepository.Find(filter);
        }

        public IComplexityLevelType Get(Guid id)
        {
            return ComplexityLevelTypeRepository.Get(id);
        }

        public bool Update(IComplexityLevelType complexityLevel)
        {
            if (ComplexityLevelTypeRepository.Update(complexityLevel))
                return true;
            else return false;
        }

        #endregion Methods
    }
}