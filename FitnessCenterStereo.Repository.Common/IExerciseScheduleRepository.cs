using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IExerciseScheduleRepository
    {

        IEnumerable<IExerciseScheduleRepository> Find(IFilter filter);
        IExerciseScheduleRepository Create(IExerciseScheduleRepository bodyPartType);
        bool Delete(Guid id);
        bool Update(IExerciseScheduleRepository bodyPartType);
        IExerciseScheduleRepository Get(Guid id);

    }
}
