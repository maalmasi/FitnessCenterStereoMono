using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
   public interface IPlanRepository
    {
        PaginatedList<IPlan> Find(IFilter filter);
        IPlan Create(IPlan planTrainer);
        bool Delete(Guid id);
        bool Update(IPlan planTrainer);
        IPlan Get(Guid id);

    }
}
