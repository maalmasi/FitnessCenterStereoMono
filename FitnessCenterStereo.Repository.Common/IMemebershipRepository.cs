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
        IMemebership Create(IMemebership Memebership);
        void Delete(Guid Id);
        void Update(Guid Id);
        IMemebership Get(Guid Id);

    }
}
