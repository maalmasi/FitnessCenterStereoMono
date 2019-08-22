using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
    public interface IMemebershipService
    {
        IEnumerable<IMemebership> Find(IFilter filter);
        IMemebership Create(IMemebership Membership);
        void Delete(Guid Id);
        void Update(Guid Id);
        IMemebership Get(Guid Id);
    }
}
