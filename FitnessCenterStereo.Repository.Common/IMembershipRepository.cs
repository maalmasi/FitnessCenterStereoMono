using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IMembershipRepository
    {
        IEnumerable<IMembership> Find(IFilter filter);
        IMembership Create(IMembership membership);
        bool Delete(Guid id);
        bool Update(IMembership membership);
        IMembership Get(Guid id);

    }
}
