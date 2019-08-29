using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IPlanTrainerRepository
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