using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

 namespace FitnessCenterStereo.Repository.Common
{
  public interface IEquipmentRepository
    {

        IEnumerable<IEquipmentRepository> Find(IFilter filter);
        IEquipmentRepository Create(IEquipmentRepository Equipment);
        void Delete(Guid Id);
        void Update(Guid Id);
        IEquipmentRepository Get(Guid Id);


    }
}
