using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
   public interface ITrainerService
    {
        IEnumerable<ITrainer> Find(IFilter filter);
        ITrainer Create(ITrainer Trainer);
        void Delete(Guid Id);
        void Update(Guid Id);
        ITrainer Get(Guid Id);
    }
}
