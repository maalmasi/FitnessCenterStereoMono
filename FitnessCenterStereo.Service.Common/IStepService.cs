using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
   public interface IStepService
    {
        PaginatedList<IStep> Find(IFilter filter);
        IStep Create(IStep step);
        bool Delete(Guid id);
        bool Update(IStep step);
        IStep Get(Guid id);
    }
}
