using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IMemebershipRepository
    {
        IEnumerable<IMemebership> Find(IFilter filter);
        IMemebership Create(IMemebership memebership);
        bool Delete(Guid id);
        bool Update(IMemebership memebership);
        IMemebership Get(Guid id);

    }
}
