using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
   public interface IPlan
    {
       
        String Name { get; set; }
        
        Guid DietTypeId { get; set; }
    }
}
