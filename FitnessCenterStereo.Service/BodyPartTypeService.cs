using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Repository;
using FitnessCenterStereo.DAL.Data;
using Microsoft.AspNetCore.Mvc;

namespace FitnessCenterStereo.Service
{
    public class BodyPartTypeService : IBodyPartTypeService
    {

        public BodyPartTypeService(IBodyPartTypeRepository bodyPartTypeRepository)
        {
            BodyPartTypeRepository = bodyPartTypeRepository;
        }

        protected IBodyPartTypeRepository BodyPartTypeRepository { get; private set; }

        public IBodyPartType Create(IBodyPartType bodyPartType)
        {
            return BodyPartTypeRepository.Create(bodyPartType);
        }

        public bool Delete(Guid id)
        {
            return BodyPartTypeRepository.Delete(id);
        }

        public IEnumerable<IBodyPartType> Find(IFilter filter)
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

    }
}
