using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
   public interface IBodyPartType : IBaseModel
    {
        
        String Firstname { get; set; }
        String LastName { get; set; }
        DateTime HiredAt { get; set; }
        
    }
}
