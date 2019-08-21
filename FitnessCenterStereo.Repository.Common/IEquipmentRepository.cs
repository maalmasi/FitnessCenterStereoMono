using System;
using System.Collections.Generic;
using System.Text;

 namespace FitnessCenterStereo.Model.Common
{
  public interface IEquipmentRepository
    {

        Guid GetById(Guid Id);
        String GetByName(String Name);
        
   
    }
}
