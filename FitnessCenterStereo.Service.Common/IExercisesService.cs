using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Service.Common
{
    public interface IExercisesService
    {
        #region Methods

        IExercises Create(IExercises exercises);

        bool Delete(Guid id);

        PaginatedList<IExercises> Find(IExercisesFilter filter);

        IExercises Get(Guid id);

        bool Update(IExercises exercises);

        #endregion Methods
    }
}