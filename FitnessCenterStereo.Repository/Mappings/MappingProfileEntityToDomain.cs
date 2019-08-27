using AutoMapper;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Model.Common;

namespace FitnessCenterStereo.Repository.Mappings
{
    public class MappingProfileEntityDomain : Profile
    {
        public MappingProfileEntityDomain()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<BodyPartType, IBodyPartType>().ReverseMap();
        }
    }
}
