using FitnessCenterStereo.Model.Common;
using System;

namespace FitnessCenterStereo.Model
{
    public class Schedule : BaseModel, ISchedule
    {
        #region Properties

        public int Frequency { get; set; }

        public Guid PlanId { get; set; }

        #endregion Properties
    }
}