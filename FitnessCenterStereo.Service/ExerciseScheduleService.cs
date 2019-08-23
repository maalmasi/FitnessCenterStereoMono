using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;

namespace FitnessCenterStereo.Service
{
    class ExerciseScheduleService
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
            if (BodyPartTypeRepository.Delete(id))
                return true;
            else return false;
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
            if (BodyPartTypeRepository.Update(bodyPartType))
                return true;
            else return false;
        }

    }

}
