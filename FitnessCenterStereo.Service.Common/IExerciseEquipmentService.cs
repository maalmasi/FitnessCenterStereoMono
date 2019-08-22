﻿using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
    public interface IExerciseEquipmentService
    {
        IEnumerable<IExerciseEquipment> Find(IFilter filter);
        IExerciseEquipment Create(IExerciseEquipment ExerciseEquipment);
        void Delete(Guid Id);
        void Update(Guid Id);
        IExerciseEquipmentService Get(Guid Id);
    }
}
