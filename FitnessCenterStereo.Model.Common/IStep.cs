using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
   public interface IStep : IBaseModel
    {
        
        String Name { get; set; }
        String Abbreviation { get; set; }
        String Description { get; set; }
        
        Guid ExercisesId { get; set; }
    }
}
