using FitnessCenterStereo.Model.Common;
using System;

namespace FitnessCenterStereo.Model
{
    public class Plan : BaseModel, IPlan
    {
        #region Properties

        public Guid DietTypeId { get; set; }
        public string Name { get; set; }

        #endregion Properties
    }
}