using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

 namespace FitnessCenterStereo.Repository.Common
{
  public interface IEquipmentRepository
    {

        IEnumerable<IEquipmentRepository> Find(IFilter filter);
        IEquipmentRepository Create(IEquipmentRepository bodyPartType);
        bool Delete(Guid id);
        bool Update(IEquipmentRepository bodyPartType);
        IEquipmentRepository Get(Guid id);


    }
}
