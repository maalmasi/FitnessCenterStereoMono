using FitnessCenterStereo.Model.Common;


namespace FitnessCenterStereo.Model
{
    public class BodyPartType : BaseModel, IBodyPartType
    {

        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }
}
