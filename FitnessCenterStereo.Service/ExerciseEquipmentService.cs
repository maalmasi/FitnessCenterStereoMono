using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;

namespace FitnessCenterStereo.Service
{
    class ExerciseEquipmentService : IExerciseEquipmentService
    {
        public ExerciseEquipmentService(IExerciseEquipmentRepository exerciseEquipmentRepository)
        {
            ExerciseEquipmentRepository = exerciseEquipmentRepository;
        }

        protected IExerciseEquipmentRepository ExerciseEquipmentRepository { get; private set; }

        public IExerciseEquipment Create(IExerciseEquipment bodyPartType)
        {
            return ExerciseEquipmentRepository.Create(bodyPartType);
        }

        public bool Delete(Guid id)
        {
            return ExerciseEquipmentRepository.Delete(id);
        }

        public PaginatedList<IExerciseEquipment> Find(IFilter filter)
        {
            return ExerciseEquipmentRepository.Find(filter);
        }

        public IExerciseEquipment Get(Guid id)
        {
            return ExerciseEquipmentRepository.Get(id);
        }

        public bool Update(IExerciseEquipment exerciseEquipment)
        {
            return ExerciseEquipmentRepository.Update(exerciseEquipment);
        }

    }

}
