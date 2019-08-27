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
    class EquipmentService : IEquipmentService
    {
        public EquipmentService(IEquipmentRepository equipmentRepository)
        {
            EquipmentRepository = equipmentRepository;
        }

        protected IEquipmentRepository EquipmentRepository { get; private set; }

        public IEquipment Create(IEquipment equipment)
        {
            return EquipmentRepository.Create(equipment);
        }

        public bool Delete(Guid id)
        {
            return EquipmentRepository.Delete(id);
        }

        public PaginatedList<IEquipment> Find(IFilter filter)
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
    }
}
