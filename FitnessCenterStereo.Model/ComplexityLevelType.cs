using FitnessCenterStereo.Model.Common;

namespace FitnessCenterStereo.Model
{
    public class ComplexityLevelType : BaseModel, IComplexityLevelType
    {
        #region Properties

        public string Abbreviation { get; set; }
        public string Name { get; set; }

        #endregion Properties
    }
}