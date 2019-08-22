using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
   public interface IStepService
    {
        IEnumerable<IStep> Find(IStep filter);
        IStep Create(IStep Step);
        void Delete(Guid Id);
        void Update(Guid Id);
        IStep Get(Guid Id);
    }
}
