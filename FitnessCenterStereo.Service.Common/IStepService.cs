using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
   public interface IStepService
    {
        IEnumerable<IStepService> Find(IStepService filter);
        IStepService Create(IStepService Step);
        void Delete(Guid Id);
        void Update(Guid Id);
        IStepService Get(Guid Id);
    }
}
