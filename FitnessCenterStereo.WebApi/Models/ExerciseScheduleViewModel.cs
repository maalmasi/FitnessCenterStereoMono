using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenterStereo.WebApi.Models
{
    public class ExerciseScheduleViewModel
    {
        public Guid ScheduleId { get; set; }
        public Guid ExerciseId { get; set; }
        public Guid ExerciseScheduledId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
