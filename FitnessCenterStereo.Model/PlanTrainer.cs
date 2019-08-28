using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model
{
    public class PlanTrainer : BaseModel,IPlanTrainer
    {
   
        public Guid TrainerId { get; set; }
        public Guid PlanId { get; set; }
    }
}
