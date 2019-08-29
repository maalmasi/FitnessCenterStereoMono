using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;

namespace FitnessCenterStereo.Service
{
    public class BodyPartTypeService : IBodyPartTypeService
    {
        #region Constructors

        public BodyPartTypeService(IBodyPartTypeRepository bodyPartTypeRepository)
        {
            BodyPartTypeRepository = bodyPartTypeRepository;
        }

        #endregion Constructors

        #region Properties

        protected IBodyPartTypeRepository BodyPartTypeRepository { get; private set; }

        #endregion Properties

        #region Methods

        public IBodyPartType Create(IBodyPartType bodyPartType)
        {
            return BodyPartTypeRepository.Create(bodyPartType);
        }

        public bool Delete(Guid id)
        {
            return BodyPartTypeRepository.Delete(id);
        }

        public PaginatedList<IBodyPartType> Find(IFilter filter)
        {
            return BodyPartTypeRepository.Find(filter);
        }

        public IBodyPartType Get(Guid id)
        {
            return BodyPartTypeRepository.Get(id);
        }

        public bool Update(IBodyPartType bodyPartType)
        {
            return BodyPartTypeRepository.Update(bodyPartType);
        }

        #endregion Methods
    }
}