using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;

namespace FitnessCenterStereo.Service
{
    class ExerciseEquipmentService
    {
        public ExerciseEquipmentService(IExerciseEquipmentRepository exerciseEquipmentRepository)
        {
            ExerciseEquipmentRepository = exerciseEquipmentRepository;
        }

        protected IBodyPartTypeRepository ExerciseEquipmentRepository { get; private set; }

        public IBodyPartType Create(IBodyPartType bodyPartType)
        {
            return ExerciseEquipmentRepository.Create(bodyPartType);
        }

        public bool Delete(Guid id)
        {
            if (ExerciseEquipmentRepository.Delete(id))
                return true;
            else return false;
        }

        public IEnumerable<IBodyPartType> Find(IFilter filter)
        {
            return ExerciseEquipmentRepository.Find(filter);
        }

        public IBodyPartType Get(Guid id)
        {
            return ExerciseEquipmentRepository.Get(id);
        }

        public bool Update(IBodyPartType bodyPartType)
        {
            if (ExerciseEquipmentRepository.Update(bodyPartType))
                return true;
            else return false;
        }

    }
}
}
