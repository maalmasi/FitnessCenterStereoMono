using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface ISchedule
    {
       
        int Frequency { get; set; }
       
        Guid PlanId { get; set; }
    }
}
