using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
   public interface ITrainerRepository
    {
        IEnumerable<ITrainerRepository> Find(IFilter filter);
        ITrainerRepository Create(ITrainerRepository bodyPartType);
        bool Delete(Guid id);
        bool Update(ITrainerRepository bodyPartType);
        ITrainerRepository Get(Guid id);

    }
}
