using AutoMapper;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
