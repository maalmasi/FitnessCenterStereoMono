using AutoMapper;
using FitnessCenterStereo.Model;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenterStereo.WebApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<BodyPartType, IBodyPartType>().ReverseMap();
        }
    }
}
