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
        IPlanTrainer Create(IPlanTrainer planTrainer);
        bool Delete(Guid id);
        bool Update(IPlanTrainer planTrainer);
        IPlanTrainer Get(Guid id);
    }
}
