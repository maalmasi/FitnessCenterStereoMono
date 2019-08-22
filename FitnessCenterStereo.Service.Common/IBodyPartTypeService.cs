using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IBodyPartTypeService
    {
        IEnumerable<IBodyPartTypeService> Find(IFilter filter);
        IBodyPartTypeService Create(IBodyPartTypeService BodyPartType);
        void Delete(Guid Id);
        void Update(Guid Id);
        IBodyPartTypeService Get(Guid Id);

    }
}
