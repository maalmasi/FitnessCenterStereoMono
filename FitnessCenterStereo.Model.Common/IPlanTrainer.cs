using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
   public interface IPlanTrainer : IBaseModel
    {
        Guid TrainerId { get; set; }
        Guid PlanId { get; set; }
       
    }
}
