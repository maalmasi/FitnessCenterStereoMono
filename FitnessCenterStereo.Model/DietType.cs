using FitnessCenterStereo.Model.Common;

namespace FitnessCenterStereo.Model
{
    public class DietType : BaseModel, IDietType
    {
        #region Properties

        public string Abbreviation { get; set; }
        public string Ingridients { get; set; }
        public string Name { get; set; }

        #endregion Properties
    }
}