using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;

namespace FitnessCenterStereo.Model.Common
{
    public interface IBodyPartTypeRepository
    {

        IEnumerable<IBodyPartTypeRepository> Find(IFilter filter);
        IBodyPartTypeRepository Create(IBodyPartTypeRepository BodyPartType);
        void Delete(Guid Id);
        void Update(Guid Id);
        IBodyPartTypeRepository Get(Guid Id);



    }
}
