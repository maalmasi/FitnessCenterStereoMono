using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model
{
    public class Compiles : ICompiles, IBaseModel
    {
        public Guid Id { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid TrainerId { get; set; }
        public Guid PlanId { get; set; }
    }
}
