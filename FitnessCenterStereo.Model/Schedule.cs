using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model
{
    public class Schedule : BaseModel, ISchedule
    {
      
        public int Frequency { get; set; }
       
        public Guid PlanId { get; set; }
    }
}
