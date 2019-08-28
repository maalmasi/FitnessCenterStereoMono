using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
    public interface IExerciseScheduleService
    {
        PaginatedList<IExerciseSchedule> Find(IFilter filter);
        IExerciseSchedule Create(IExerciseSchedule exerciseSchedule);
        bool Delete(Guid id);
        bool Update(IExerciseSchedule exerciseSchedule);
        IExerciseSchedule Get(Guid id);
    }
}
