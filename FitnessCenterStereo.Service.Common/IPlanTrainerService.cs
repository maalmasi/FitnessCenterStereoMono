using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
   public interface IPlanTrainerService
    {
        PaginatedList<IPlanTrainer> Find(IFilter filter);
        IPlanTrainer Create(IPlanTrainer planTrainer);
        bool Delete(Guid id);
        bool Update(IPlanTrainer planTrainer);
        IPlanTrainer Get(Guid id);
    }
}
