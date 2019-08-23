using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IDietTypeRepository
    {

        IEnumerable<IDietType> Find(IFilter filter);
        IDietType Create(IDietType bodyPartType);
        bool Delete(Guid id);
        bool Update(IDietType dietType);
        IDietType Get(Guid id);

    }
}
