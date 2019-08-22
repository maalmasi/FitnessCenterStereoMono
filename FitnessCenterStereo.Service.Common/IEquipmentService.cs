using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

 namespace FitnessCenterStereo.Service.Common
{
  public interface IEquipmentService
    {

        IEnumerable<IEquipment> Find(IFilter filter);
        IDietTypeService Create(IEquipment Equipment);
        void Delete(Guid Id);
        void Update(Guid Id);
        IEquipment Get(Guid Id);
    }
}
