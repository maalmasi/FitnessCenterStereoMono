using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model
{
    public class ExerciseSchedule : BaseModel, IExerciseSchedule
    {
        public Guid ScheduleId { get; set; }
        public Guid ExerciseId { get; set; }
        public Guid ExerciseScheduledId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
