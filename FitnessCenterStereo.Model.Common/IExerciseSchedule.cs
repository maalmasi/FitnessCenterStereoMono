﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IExerciseSchedule
    {
        Guid ScheduleId { get; set; }
        Guid ExerciseId { get; set; }
        Guid ExerciseScheduledId { get; set; }
        
    }
}