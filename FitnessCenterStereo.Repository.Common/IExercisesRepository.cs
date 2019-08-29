using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IExercisesRepository
    {
        #region Methods

        IExercises Create(IExercises exercises);

        bool Delete(Guid id);

        PaginatedList<IExercises> Find(IFilter filter);

        IExercises Get(Guid id);

        bool Update(IExercises exercises);

        #endregion Methods
    }
}