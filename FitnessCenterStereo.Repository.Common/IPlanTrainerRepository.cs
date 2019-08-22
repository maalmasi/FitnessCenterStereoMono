using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
   public interface IPlanTrainerRepository
    {
        IEnumerable<IPlanTrainerRepository> Find(IFilter filter);
        IPlanTrainerRepository Create(IPlanTrainerRepository PlanTrainer);
        void Delete(Guid Id);
        void Update(Guid Id);
        IPlanTrainerRepository Get(Guid Id);

    }
}
