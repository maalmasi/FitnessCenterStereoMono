using System;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class PlanTrainer
    {
        #region Properties

        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public Guid? Id { get; set; }
        public virtual Trainer IdNavigation { get; set; }
        public virtual Plan Plan { get; set; }
        public Guid? PlanId { get; set; }
        public Guid TrainerId { get; set; }

        #endregion Properties
    }
}