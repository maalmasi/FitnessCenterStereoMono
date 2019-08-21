using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
   public interface ICompilesRepository
    {
        Guid GetByTrainerId(Guid TrainerId);
        Guid GetByPlanId(Guid PlanId);
        
    }
}
