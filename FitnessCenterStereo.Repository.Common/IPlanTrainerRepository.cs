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
        IPlanTrainer Create(IPlanTrainer PlanTrainer);
        void Delete(Guid Id);
        void Update(Guid Id);
        IPlanTrainer Get(Guid Id);

    }
}
