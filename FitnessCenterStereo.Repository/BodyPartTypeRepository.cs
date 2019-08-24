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
        protected ApplicationDbContext AppDbContext { get; private set; }
        protected IMapper Mapper { get; private set; }

        public BodyPartTypeRepository(ApplicationDbContext applicationDbContext, IMapper mapperInterface)
        {
            AppDbContext = applicationDbContext;
            Mapper = mapperInterface;
        }

        public IBodyPartType Create(IBodyPartType bodyPartType)
        {
            bodyPartType.Id = Guid.NewGuid();
            bodyPartType.DateCreated = DateTime.UtcNow;
            bodyPartType.DateUpdated = DateTime.UtcNow;
            AppDbContext.BodyPartType.Add(Mapper.Map<BodyPartType>(bodyPartType));
            AppDbContext.SaveChanges();
            return bodyPartType;
        }

        public bool Delete(Guid id)
        {
            var toDelete = AppDbContext.BodyPartType.Find(id);
            AppDbContext.BodyPartType.Remove(toDelete);
            AppDbContext.SaveChanges();

            return true;
        }

        public IEnumerable<IBodyPartType> Find(IFilter filter)
        {
            return (IEnumerable<IBodyPartType>)AppDbContext.BodyPartType.Find(filter);
        }

        public IBodyPartType Get(Guid id)
        {
            return Mapper.Map<IBodyPartType>(AppDbContext.BodyPartType.Find(id));
        }

        public bool Update(IBodyPartType bodyPartType)
        {
            AppDbContext.BodyPartType.Update(Mapper.Map<BodyPartType>(bodyPartType));
            return AppDbContext.SaveChanges() == 1;
        }
    }
}
