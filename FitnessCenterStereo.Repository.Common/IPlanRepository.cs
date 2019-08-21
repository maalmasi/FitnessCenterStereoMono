using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
   public interface IPlanRepository
    {
        Guid GetById(Guid Id);
        String GetByName(String Name);
     
    }
}
