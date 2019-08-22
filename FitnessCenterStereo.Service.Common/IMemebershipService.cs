using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IMemebershipService
    {
        IEnumerable<IMemebershipService> Find(IFilter filter);
        IMemebershipService Create(IMemebershipService Membership);
        void Delete(Guid Id);
        void Update(Guid Id);
        IMemebershipService Get(Guid Id);
    }
}
