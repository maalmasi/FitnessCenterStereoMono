using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model
{
    public class Plan : BaseModel, IPlan
    {
      
        public string Name { get; set; }
    
        public Guid DietTypeId { get; set; }
    }
}

