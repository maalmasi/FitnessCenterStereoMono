using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
    public interface IDietTypeService
    {
        IEnumerable<IDietType> Find(IFilter filter);
        IDietType Create(IDietType dietType);
        bool Delete(Guid id);
        bool Update(IDietType dietType);
        IDietType Get(Guid id);
    }
}
