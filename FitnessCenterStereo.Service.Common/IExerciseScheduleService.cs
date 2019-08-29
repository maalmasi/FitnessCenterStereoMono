using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Service.Common
{
    public interface IExerciseScheduleService
    {
        #region Methods

        IExerciseSchedule Create(IExerciseSchedule exerciseSchedule);

        bool Delete(Guid id);

        PaginatedList<IExerciseSchedule> Find(IFilter filter);

        IExerciseSchedule Get(Guid id);

        bool Update(IExerciseSchedule exerciseSchedule);

        #endregion Methods
    }
}