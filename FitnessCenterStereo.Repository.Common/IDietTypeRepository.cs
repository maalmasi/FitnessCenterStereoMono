using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IDietTypeRepository
    {

        IEnumerable<IDietTypeRepository> Find(IFilter filter);
        IDietTypeRepository Create(IDietTypeRepository bodyPartType);
        bool Delete(Guid id);
        bool Update(IDietTypeRepository bodyPartType);
        IDietTypeRepository Get(Guid id);

    }
}
