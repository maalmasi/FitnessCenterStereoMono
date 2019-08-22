using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class PlanTrainer
    {
        public Guid? Id { get; set; }
        public Guid? PlanId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public Guid TrainerId { get; set; }

        public virtual Trainer IdNavigation { get; set; }
        public virtual Plan Plan { get; set; }
    }
}
