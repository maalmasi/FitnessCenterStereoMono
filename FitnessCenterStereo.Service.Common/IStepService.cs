using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
   public interface IStepService
    {
        IEnumerable<IStep> Find(IFilter filter);
        IStep Create(IStep step);
        bool Delete(Guid id);
        bool Update(IStep step);
        IStep Get(Guid id);
    }
}
