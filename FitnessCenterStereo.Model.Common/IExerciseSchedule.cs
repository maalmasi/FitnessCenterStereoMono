using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IExerciseSchedule : IBaseModel
    {
        Guid ScheduleId { get; set; }
        Guid ExerciseId { get; set; }        
    }
}
