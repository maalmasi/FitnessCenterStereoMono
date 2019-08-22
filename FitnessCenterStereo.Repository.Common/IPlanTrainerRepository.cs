using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
   public interface IPlanTrainerRepository
    {
        IEnumerable<IPlanTrainer> Find(IFilter filter);
        IPlanTrainerRepository Create(IPlanTrainerRepository PlanTrainer);
        void Delete(Guid Id);
        void Update(Guid Id);
        IPlanTrainery Get(Guid Id);

    }
}
