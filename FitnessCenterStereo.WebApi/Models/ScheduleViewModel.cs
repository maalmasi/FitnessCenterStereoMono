using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenterStereo.WebApi.Models
{
    public class ScheduleViewModel
    {
        public Guid Id { get; set; }
        public int Frequency { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Guid PlanId { get; set; }
    }
}
