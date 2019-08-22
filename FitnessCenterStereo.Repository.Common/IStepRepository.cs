using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
   public interface IStepRepository
    {
        IEnumerable<IStepRepository> Find(IFilter filter);
        IStepRepository Create(IStepRepository Step);
        void Delete(Guid Id);
        void Update(Guid Id);
        IStepRepository Get(Guid Id);

    }
}
