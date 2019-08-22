using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

 namespace FitnessCenterStereo.Model.Common
{
  public interface IEquipmentService
    {

        IEnumerable<IEquipmentService> Find(IFilter filter);
        IDietTypeService Create(IEquipmentService Equipment);
        void Delete(Guid Id);
        void Update(Guid Id);
        IEquipmentService Get(Guid Id);
    }
}
