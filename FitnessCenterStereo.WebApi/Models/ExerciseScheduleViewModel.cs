using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenterStereo.WebApi.Models
{
    public class ExerciseScheduleViewModel : BaseViewModel
    {
        public Guid ScheduleId { get; set; }
        public Guid ExerciseId { get; set; }
    }
}
