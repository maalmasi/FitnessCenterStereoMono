using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Compiles
    {
        public Guid? Id { get; set; }
        public Guid? PlanId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public Guid CompilesId { get; set; }

        public virtual Trainer IdNavigation { get; set; }
        public virtual Plan Plan { get; set; }
    }
}
