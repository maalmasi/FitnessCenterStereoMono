using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
   public interface IStepRepository
    {
        IEnumerable<IStep> Find(IFilter filter);
        IStep Create(IStep Step);
        void Delete(Guid Id);
        void Update(Guid Id);
        IStep Get(Guid Id);

    }
}
