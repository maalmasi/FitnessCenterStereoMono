using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model
{
    class Step : BaseModel, IStep
    {
   
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }
   
        public Guid ExercisesId { get; set; }
    }
}
