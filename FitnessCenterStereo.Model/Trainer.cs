using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model
{
    public class Trainer : IBaseModel, ITrainer
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public DateTime HiredAt { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
