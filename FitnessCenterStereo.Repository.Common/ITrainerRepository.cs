using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
   public interface ITrainerRepository
    {
        IEnumerable<ITrainerRepository> Find(IFilter filter);
        ITrainerRepository Create(ITrainerRepository Trainer);
        void Delete(Guid Id);
        void Update(Guid Id);
        ITrainerRepository Get(Guid Id);


    }
}
