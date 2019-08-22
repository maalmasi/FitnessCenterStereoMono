using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
   public interface ITrainerService
    {
        IEnumerable<ITrainerService> Find(IFilter filter);
        ITrainerService Create(ITrainerService Trainer);
        void Delete(Guid Id);
        void Update(Guid Id);
        ITrainerService Get(Guid Id);
    }
}
