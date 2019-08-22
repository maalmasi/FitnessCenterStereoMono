using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model
{
    public class Exercises : BaseModel, IExercises
    {
        
        public string Name { get; set; }
      
        public Guid BodyPartId { get; set; }
        public Guid ComplexityLevelTypeId { get; set; }
    }
}
