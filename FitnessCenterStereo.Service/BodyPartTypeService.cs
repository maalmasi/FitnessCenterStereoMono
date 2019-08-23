using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Repository;
using FitnessCenterStereo.DAL.Data;

namespace FitnessCenterStereo.Service
{
    public class BodyPartTypeService : IBodyPartTypeService
    {

        private ApplicationDbContext AppDbContext;

       
        public IBodyPartType Create(IBodyPartType BodyPartType)
        {
            IBodyPartTypeRepository BodyPart = new BodyPartTypeRepository(AppDbContext);
            return BodyPart.Create(BodyPartType);
        }

        public void Delete(Guid Id)
        {
            IBodyPartTypeRepository BodyPart = new BodyPartTypeRepository(AppDbContext);
            BodyPart.Delete(Id);
        }

        public IEnumerable<IBodyPartType> Find(IFilter filter)
        {
            IBodyPartTypeRepository BodyPart = new BodyPartTypeRepository(AppDbContext);
            return BodyPart.Find(filter);
        }

        public IBodyPartType Get(Guid Id)
        {
            IBodyPartTypeRepository BodyPart = new BodyPartTypeRepository(AppDbContext);
            return BodyPart.Get(Id);
        }

        public void Update(Guid Id)
        {
            IBodyPartTypeRepository BodyPart = new BodyPartTypeRepository(AppDbContext);
            BodyPart.Update(Id);
        }
    }
}
