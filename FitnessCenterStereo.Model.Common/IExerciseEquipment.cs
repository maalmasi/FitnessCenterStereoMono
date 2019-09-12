﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IExerciseEquipment
    {
        Guid ExerciseId { get; set; }
        Guid EquipmentId { get; set; }
        
        Guid ExerciseEquipmentId { get; set; }
    }
}