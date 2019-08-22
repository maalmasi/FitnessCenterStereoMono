using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
   public interface IPlanTrainerRepository
    {
        Guid GetByTrainerId(Guid TrainerId);
        Guid GetByPlanId(Guid PlanId);
        
    }
}
