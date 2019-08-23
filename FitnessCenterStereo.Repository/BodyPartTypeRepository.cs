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

        protected ApplicationDbContext appDbContext { get; private set; }

        public BodyPartTypeRepository(ApplicationDbContext applicationDbContext)
        {
            appDbContext = applicationDbContext;
        }
      
       
        public IBodyPartType Create(IBodyPartType BodyPartType)
        {
            return (IBodyPartType)appDbContext.BodyPartType.Add(new BodyPartType());
        }

        public bool Delete(Guid id)
        {
            
            
           BodyPartType ToDelete = appDbContext.BodyPartType.Find(id);
           if (ToDelete != null) { appDbContext.BodyPartType.Remove(ToDelete); return true; }

            return false;

            

        }

        public IEnumerable<IBodyPartType> Find(IFilter filter)
        {
            return (IEnumerable<IBodyPartType>)appDbContext.BodyPartType.Find(filter);
        }

        public IBodyPartType Get(Guid Id)
        {
            IBodyPartType bodyPartType = (IBodyPartType)appDbContext.BodyPartType.Find(Id);
            return bodyPartType;
        }

        public bool Update(IBodyPartType bodyPartType)
        {
            BodyPartType ToUpdate = appDbContext.BodyPartType.Find(bodyPartType);
             appDbContext.BodyPartType.Update(ToUpdate);
            if (ToUpdate != bodyPartType) { return true;}

            return false;
            
        }

      
        
    }
}
