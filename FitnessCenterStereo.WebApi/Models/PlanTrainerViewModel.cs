using System;

namespace FitnessCenterStereo.WebApi.Models
{
    public class PlanTrainerViewModel : BaseViewModel
    {
        #region Properties

        public Guid PlanId { get; set; }
        public Guid TrainerId { get; set; }

        #endregion Properties
    }
}