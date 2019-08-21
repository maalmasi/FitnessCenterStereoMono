using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
   public interface IExercises : IBaseModel
    {
      
        String Name { get; set; }
       
        Guid BodyPartId { get; set; }
        Guid ComplexityLevelTypeId { get; set; }

    }
}
