using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
   public interface IPlanTrainerRepository
    {
        IEnumerable<IPlanTrainerRepository> Find(IFilter filter);
        IPlanTrainerRepository Create(IPlanTrainerRepository bodyPartType);
        bool Delete(Guid id);
        bool Update(IPlanTrainerRepository bodyPartType);
        IPlanTrainerRepository Get(Guid id);

    }
}
