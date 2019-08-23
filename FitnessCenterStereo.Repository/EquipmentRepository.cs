using FitnessCenterStereo.Common;
using FitnessCenterStereo.Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository
{
    class EquipmentRepository : IEquipmentRepository
    {
        public IEquipmentRepository Create(IEquipmentRepository bodyPartType)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEquipmentRepository> Find(IFilter filter)
        {
            throw new NotImplementedException();
        }

        public IEquipmentRepository Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(IEquipmentRepository bodyPartType)
        {
            throw new NotImplementedException();
        }
    }
}
