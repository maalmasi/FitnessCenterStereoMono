using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;

namespace FitnessCenterStereo.Service
{
    internal class ExerciseEquipmentService : IExerciseEquipmentService
    {
        #region Constructors

        public ExerciseEquipmentService(IExerciseEquipmentRepository exerciseEquipmentRepository)
        {
            ExerciseEquipmentRepository = exerciseEquipmentRepository;
        }

        #endregion Constructors

        #region Properties

        protected IExerciseEquipmentRepository ExerciseEquipmentRepository { get; private set; }

        #endregion Properties

        #region Methods

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

        #endregion Methods
    }
}