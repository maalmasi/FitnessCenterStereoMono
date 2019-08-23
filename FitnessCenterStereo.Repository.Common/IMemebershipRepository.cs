using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IMemebershipRepository
    {
        IEnumerable<IMemebershipRepository> Find(IFilter filter);
        IMemebershipRepository Create(IMemebershipRepository bodyPartType);
        bool Delete(Guid id);
        bool Update(IMemebershipRepository bodyPartType);
        IMemebershipRepository Get(Guid id);

    }
}
