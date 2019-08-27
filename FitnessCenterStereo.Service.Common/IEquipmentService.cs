using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Collections.Generic;
using System.Text;

 namespace FitnessCenterStereo.Service.Common
{
  public interface IEquipmentService
    {

        PaginatedList<IEquipment> Find(IFilter filter);
        IEquipment Create(IEquipment equipment);
        bool Delete(Guid id);
        bool Update(IEquipment equipment);
        IEquipment Get(Guid id);
    }
}
