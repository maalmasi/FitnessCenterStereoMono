using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IBodyPartType:IBaseModel
    {
        
        String Name { get; set; }
        String Abbreviation { get; set; }
        

    }
}
