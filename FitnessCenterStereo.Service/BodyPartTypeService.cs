using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Repository;
using FitnessCenterStereo.DAL.Data;

namespace FitnessCenterStereo.Service
{
    public class BodyPartTypeService : IBodyPartTypeService
    {

        public BodyPartTypeService(IBodyPartTypeRepository bodyPartTypeRepository)
        {
            BodyPartTypeRepository = bodyPartTypeRepository;
        }

        protected IBodyPartTypeRepository BodyPartTypeRepository { get; private set; }

        public IBodyPartType Create(IBodyPartType BodyPartType)
        {
            return BodyPartTypeRepository.Create(BodyPartType);
        }

        public void Delete(Guid Id)
        {
            BodyPartTypeRepository.Delete(Id);
        }

        public IEnumerable<IBodyPartType> Find(IFilter filter)
        {
            return BodyPartTypeRepository.Find(filter);
        }

        public IBodyPartType Get(Guid Id)
        {
            return BodyPartTypeRepository.Get(Id);
        }

        public void Update(Guid Id)
        {
            BodyPartTypeRepository.Update(Id);
        }
    }
}
