using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model
{
    public class ComplexityLevelType : BaseModel, IComplexityLevelType
    {
    
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    
    }
}
