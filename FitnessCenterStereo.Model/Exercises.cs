using FitnessCenterStereo.Model.Common;
using System;

namespace FitnessCenterStereo.Model
{
    public class Exercises : BaseModel, IExercises
    {
        #region Properties

        public Guid BodyPartId { get; set; }
        public Guid ComplexityLevelTypeId { get; set; }
        public string Name { get; set; }

        #endregion Properties
    }
}