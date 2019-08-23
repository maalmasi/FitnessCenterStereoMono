using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
   public interface ITrainerRepository
    {
        IEnumerable<ITrainer> Find(IFilter filter);
        ITrainer Create(ITrainer trainer);
        bool Delete(Guid id);
        bool Update(ITrainer trainer);
        ITrainer Get(Guid id);

    }
}
