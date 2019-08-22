using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model
{
  public  class BodyPartType : BaseModel,IBodyPartType
    {
       
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }
}
