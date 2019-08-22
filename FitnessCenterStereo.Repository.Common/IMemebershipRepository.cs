using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IMemebershipRepository
    {
        IEnumerable<IMemebershipRepository> Find(IFilter filter);
        IMemebershipRepository Create(IMemebershipRepository Memebership);
        void Delete(Guid Id);
        void Update(Guid Id);
        IMemebershipRepository Get(Guid Id);

    }
}
