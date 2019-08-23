using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
   public interface IBodyPartTypeRepository
    {
        IEnumerable<IBodyPartTypeRepository> Find(IFilter filter);
        IBodyPartTypeRepository Create(IBodyPartTypeRepository bodyPartType);
        bool Delete(Guid id);
        bool Update(IBodyPartTypeRepository bodyPartType);
        IBodyPartTypeRepository Get(Guid id);

    }
}
