using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
   public interface IPlanService
    {
        PaginatedList<IPlan> Find(IFilter filter);
        IPlan Create(IPlan plan);
        bool Delete(Guid id);
        bool Update(IPlan plan);
        IPlan Get(Guid id);
    }
}
