using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IDietTypeService
    {
        IEnumerable<IDietTypeService> Find(IFilter filter);
        IDietTypeService Create(IDietTypeService DietType);
        void Delete(Guid Id);
        void Update(Guid Id);
        IDietTypeService Get(Guid Id);
    }
}
