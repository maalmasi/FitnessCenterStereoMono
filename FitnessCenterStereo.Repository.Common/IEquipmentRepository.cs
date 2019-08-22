using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

 namespace FitnessCenterStereo.Repository.Common
{
  public interface IEquipmentRepository
    {

        IEnumerable<IEquipment> Find(IFilter filter);
        IEquipment Create(IEquipment Equipment);
        void Delete(Guid Id);
        void Update(Guid Id);
        IEquipment Get(Guid Id);


    }
}
