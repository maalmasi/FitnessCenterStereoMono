using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
   public interface IStepRepository
    {
        IEnumerable<IStepRepository> Find(IFilter filter);
        IStepRepository Create(IStepRepository bodyPartType);
        bool Delete(Guid id);
        bool Update(IStepRepository bodyPartType);
        IStepRepository Get(Guid id);

    }
}
