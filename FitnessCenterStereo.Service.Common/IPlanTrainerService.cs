using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Service.Common
{
    public interface IPlanTrainerService
    {
        #region Methods

        IPlanTrainer Create(IPlanTrainer planTrainer);

        bool Delete(Guid id);

        PaginatedList<IPlanTrainer> Find(IFilter filter);

        IPlanTrainer Get(Guid id);

        bool Update(IPlanTrainer planTrainer);

        #endregion Methods
    }
}