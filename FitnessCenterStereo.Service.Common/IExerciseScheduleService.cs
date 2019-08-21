using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IExerciseScheduleService
    {
        Guid GetbyId(Guid Id);
    }
}
