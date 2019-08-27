using AutoMapper;
using FitnessCenterStereo.WebApi.Models;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.WebApi.Infrastracture.Pagination;



namespace FitnessCenterStereo.WebApi.Mappings
{
    public class MappingProfileViewDomain : Profile
    {
        public MappingProfileViewDomain()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<IBodyPartType, BodyPartTypeViewModel>().ReverseMap();
            CreateMap<Model.Common.Infrastracture.Pagination.PaginatedList<IBodyPartType>, Infrastracture.Pagination.PaginatedList<BodyPartTypeViewModel>>().ReverseMap();

            CreateMap<IBodyPartType, BodyPartTypeViewModel>().ReverseMap();
            CreateMap<Model.Common.Infrastracture.Pagination.PaginatedList<IBodyPartType>, Infrastracture.Pagination.PaginatedList<BodyPartTypeViewModel>>().ReverseMap();

        }
    }
}
