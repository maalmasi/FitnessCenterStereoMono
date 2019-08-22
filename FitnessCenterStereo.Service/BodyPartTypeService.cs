using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Repository;


namespace FitnessCenterStereo.Service
{
    class BodyPartTypeService : IBodyPartTypeService
    {
        public IBodyPartType Create(IBodyPartType BodyPartType)
        {
            IBodyPartTypeRepository BodyPart = new BodyPartTypeRepository();
            return BodyPart.Create(BodyPartType);
        }

        public void Delete(Guid Id)
        {
            IBodyPartTypeRepository BodyPart = new BodyPartTypeRepository();
            BodyPart.Delete(Id);
        }

        public IEnumerable<IBodyPartType> Find(IFilter filter)
        {
            IBodyPartTypeRepository BodyPart = new BodyPartTypeRepository();
            return BodyPart.Find(filter);
        }

        public IBodyPartType Get(Guid Id)
        {
            IBodyPartTypeRepository BodyPart = new BodyPartTypeRepository();
            return BodyPart.Get(Id);
        }

        public void Update(Guid Id)
        {
            IBodyPartTypeRepository BodyPart = new BodyPartTypeRepository();
            BodyPart.Update(Id);
        }
    }
}
