using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
   public interface IPlanTrainerRepository
    {
        PaginatedList<IPlanTrainer> Find(IFilter filter);
        IPlanTrainer Create(IPlanTrainer planTrainer);
        bool Delete(Guid id);
        bool Update(IPlanTrainer planTrainer);
        IPlanTrainer Get(Guid id);

    }
}
