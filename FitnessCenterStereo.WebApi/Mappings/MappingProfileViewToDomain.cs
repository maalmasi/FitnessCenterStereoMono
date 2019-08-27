using AutoMapper;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.WebApi.Models;

namespace FitnessCenterStereo.WebApi.Mappings
{
    public class MappingProfileViewDomain : Profile
    {
        public MappingProfileViewDomain()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap(IBodyPartType, BodyPartTypeViewModel)().ReverseMap(); ;
            CreateMap<ICard, CardViewModel>().ReverseMap(); ;
            CreateMap(typeof(WebApi.Infrastracture.Pagination.PaginatedList<>), typeof(Model.Common.Infrastracture.Pagination.PaginatedList<>)).ReverseMap();
        }
    }
}
