using FitnessCenterStereo.Model.Common;

namespace FitnessCenterStereo.Model
{
    public class BodyPartType : BaseModel, IBodyPartType
    {
        #region Properties

        public string Abbreviation { get; set; }
        public string Name { get; set; }

        #endregion Properties
    }
}