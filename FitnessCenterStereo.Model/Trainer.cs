using FitnessCenterStereo.Model.Common;
using System;

namespace FitnessCenterStereo.Model
{
    public class Trainer : BaseModel, ITrainer
    {
        #region Properties

        public string Firstname { get; set; }
        public DateTime HiredAt { get; set; }
        public string LastName { get; set; }

        #endregion Properties
    }
}