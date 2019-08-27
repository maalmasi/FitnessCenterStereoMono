using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenterStereo.WebApi.Models
{
    public class PlanTrainerViewModel : BaseViewModel
    {
        public Guid TrainerId { get; set; }
        public Guid PlanId { get; set; }
    }
}
