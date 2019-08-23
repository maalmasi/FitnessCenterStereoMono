using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
   public interface IBodyPartTypeRepository
    {
        IEnumerable<IStep> Find(IFilter filter);
        IStepRepository Create(IStep step);
        bool Delete(Guid id);
        bool Update(IStep step);
        IStep Get(Guid id);

    }
}
