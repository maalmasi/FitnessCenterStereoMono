using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model
{
    public class Schedule : BaseModel, ISchedule
    {
        public Guid Id { get; set; }
        public int Frequency { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Guid PlanId { get; set; }
    }
}
