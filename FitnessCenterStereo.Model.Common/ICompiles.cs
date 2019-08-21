using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
   public interface ICompiles : IBaseModel
    {
        Guid TrainerId { get; set; }
        Guid PlanId { get; set; }
       
    }
}
