using AutoMapper;
using FitnessCenterStereo.WebApi.Models;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenterStereo.WebApi.Mappings
{
    public class MappingProfileViewDomain : Profile
    {
        public MappingProfileViewDomain()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<BodyPartTypeViewModel, IBodyPartType>().ReverseMap();
        }
    }
}
