using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
   public interface IPlanTrainerService
    {
        IEnumerable<IPlanTrainerService> Find(IFilter filter);
        IPlanTrainerService Create(IPlanTrainerService PlanTrainer);
        void Delete(Guid Id);
        void Update(Guid Id);
        IPlanTrainerService Get(Guid Id);
    }
}
