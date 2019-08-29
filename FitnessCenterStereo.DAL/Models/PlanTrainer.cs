using System;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class PlanTrainer : BaseModel
    {
        #region Properties

        public virtual Trainer IdNavigation { get; set; }
        public virtual Plan Plan { get; set; }
        public Guid? PlanId { get; set; }
        public Guid TrainerId { get; set; }

        #endregion Properties
    }
}