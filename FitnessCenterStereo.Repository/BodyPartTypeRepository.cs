using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace FitnessCenterStereo.Repository
{
    public class BodyPartTypeRepository : IBodyPartTypeRepository
    {

        protected ApplicationDbContext AppDbContext { get; private set; }

        public BodyPartTypeRepository(ApplicationDbContext applicationDbContext)
        {
            AppDbContext = applicationDbContext;
        }
      
       
        public IBodyPartType Create(IBodyPartType BodyPartType)
        {
            return (IBodyPartType)AppDbContext.BodyPartType.Add((BodyPartType)BodyPartType);
        }

        public void Delete(Guid Id)
        {
            BodyPartType ToDelete = AppDbContext.BodyPartType.Find(Id);
            AppDbContext.BodyPartType.Remove(ToDelete);
        }

        public IEnumerable<IBodyPartType> Find(IFilter filter)
        {
            return (IEnumerable<IBodyPartType>)AppDbContext.BodyPartType.Find(filter);
        }

        public IBodyPartType Get(Guid Id)
        {
            var t = AppDbContext.BodyPartType.Find(Id);
            return default(IBodyPartType);
        }

        public void Update(Guid Id)
        {
            BodyPartType ToUpdate = AppDbContext.BodyPartType.Find(Id);
            AppDbContext.BodyPartType.Update(ToUpdate);
        }
    }
}
