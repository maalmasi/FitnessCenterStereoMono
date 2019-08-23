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
            return (IBodyPartType)appDbContext.BodyPartType.Add((BodyPartType)BodyPartType);
        }

        public bool Delete(Guid Id)
        {
            BodyPartType ToDelete = appDbContext.BodyPartType.Find(Id);
            appDbContext.BodyPartType.Remove(ToDelete);
            return true;
        }

        public IEnumerable<IBodyPartType> Find(IFilter filter)
        {
            return (IEnumerable<IBodyPartType>)appDbContext.BodyPartType.Find(filter);
        }

        public IBodyPartType Get(Guid Id)
        {
            var t = AppDbContext.BodyPartType.Find(Id);
            return default(IBodyPartType);
        }

        public bool Update(IBodyPartType bodyPartType)
        {
            //BodyPartType ToUpdate = AppDbContext.BodyPartType.Find(Id);
            //AppDbContext.BodyPartType.Update(ToUpdate);
            return true;
        }

      
        
    }
}
