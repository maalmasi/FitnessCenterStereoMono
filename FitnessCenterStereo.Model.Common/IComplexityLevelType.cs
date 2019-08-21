using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IComplexityLevelType : IBaseModel { 


        String Name { get; set; }
        String Abbreviation { get; set; }
       
    }
}
