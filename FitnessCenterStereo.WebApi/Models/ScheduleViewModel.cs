﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenterStereo.WebApi.Models
{
    public class ScheduleViewModel : BaseViewModel
    {
        public int Frequency { get; set; }
        public Guid PlanId { get; set; }
    }
}
