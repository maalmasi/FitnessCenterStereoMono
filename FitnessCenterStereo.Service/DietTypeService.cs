using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;

namespace FitnessCenterStereo.Service
{
    internal class DietTypeService : IDietTypeService
    {
        #region Constructors

        public DietTypeService(IDietTypeRepository dietTypeRepository)
        {
            DietTypeRepository = dietTypeRepository;
        }

        #endregion Constructors

        #region Properties

        protected IDietTypeRepository DietTypeRepository { get; private set; }

        #endregion Properties

        #region Methods

        public IDietType Create(IDietType dietType)
        {
            return DietTypeRepository.Create(dietType);
        }

        public bool Delete(Guid id)
        {
            return DietTypeRepository.Delete(id);
        }

        public PaginatedList<IDietType> Find(IDietTypeFilter filter)
        {
            return DietTypeRepository.Find(filter);
        }

        public IDietType Get(Guid id)
        {
            return DietTypeRepository.Get(id);
        }

        public bool Update(IDietType dietType)
        {
            return DietTypeRepository.Update(dietType);
        }

        #endregion Methods
    }
}