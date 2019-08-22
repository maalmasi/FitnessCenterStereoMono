using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
   public interface IPlanTrainerService
    {
        IEnumerable<IPlanTrainer> Find(IFilter filter);
        IPlanTrainerService Create(IPlanTrainer PlanTrainer);
        void Delete(Guid Id);
        void Update(Guid Id);
        IPlanTrainer Get(Guid Id);
    }
}
