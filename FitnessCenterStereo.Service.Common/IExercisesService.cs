using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
   public interface IExercisesService
    {
        PaginatedList<IExercises> Find(IFilter filter);
        IExercises Create(IExercises exercises);
        bool Delete(Guid id);
        bool Update(IExercises exercises);
        IExercises Get(Guid id);
    }
}
