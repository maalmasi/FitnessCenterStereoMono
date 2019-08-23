using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.DAL.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace FitnessCenterStereo.Repository
{
    public class BodyPartTypeRepository : IBodyPartTypeRepository
    {
        protected ApplicationDbContext appDbContext { get; private set; }
        private readonly IMapper mapper;

        public BodyPartTypeRepository(ApplicationDbContext applicationDbContext, IMapper mapperInterface)
        {
            appDbContext = applicationDbContext;
            mapper = mapperInterface;
        }

        public IBodyPartType Create(IBodyPartType BodyPartType)
        {
            var created = appDbContext.BodyPartType.Add(mapper.Map<BodyPartType>(BodyPartType));
            appDbContext.SaveChanges();
            return mapper.Map<IBodyPartType>(created.Entity);
        }

        public bool Delete(Guid id)
        {
            var toDelete = appDbContext.BodyPartType.Find(id);
            appDbContext.BodyPartType.Remove(toDelete);
            appDbContext.SaveChanges();

            return true;
        }

        public IEnumerable<IBodyPartType> Find(IFilter filter)
        {
            return (IEnumerable<IBodyPartType>)appDbContext.BodyPartType.Find(filter);
        }

        public IBodyPartType Get(Guid Id)
        {
            return mapper.Map<IBodyPartType>(appDbContext.BodyPartType.Find(Id));
        }

        public bool Update(IBodyPartType bodyPartType)
        {
            appDbContext.BodyPartType.Update(mapper.Map<BodyPartType>(bodyPartType));
            appDbContext.SaveChanges();
            return true;
        }
    }
}
