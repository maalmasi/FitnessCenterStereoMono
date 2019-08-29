using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Repository.Common
{
    public interface ITrainerRepository
    {
        #region Methods

        ITrainer Create(ITrainer trainer);

        bool Delete(Guid id);

        PaginatedList<ITrainer> Find(IFilter filter);

        ITrainer Get(Guid id);

        bool Update(ITrainer trainer);

        #endregion Methods
    }
}