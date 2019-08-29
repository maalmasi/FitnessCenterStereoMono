using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;

namespace FitnessCenterStereo.Service
{
    internal class EquipmentService : IEquipmentService
    {
        #region Constructors

        public EquipmentService(IEquipmentRepository equipmentRepository)
        {
            EquipmentRepository = equipmentRepository;
        }

        #endregion Constructors

        #region Properties

        protected IEquipmentRepository EquipmentRepository { get; private set; }

        #endregion Properties

        #region Methods

        public IEquipment Create(IEquipment equipment)
        {
            return EquipmentRepository.Create(equipment);
        }

        public bool Delete(Guid id)
        {
            return EquipmentRepository.Delete(id);
        }

        public PaginatedList<IEquipment> Find(IEquipmentFilter filter)
        {
            return EquipmentRepository.Find(filter);
        }

        public IEquipment Get(Guid id)
        {
            return EquipmentRepository.Get(id);
        }

        public bool Update(IEquipment equipment)
        {
            return EquipmentRepository.Update(equipment);
        }

        #endregion Methods
    }
}