using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IDietTypeRepository
    {
        IEnumerable<IDietTypeRepository> Find(IFilter filter);
        IDietTypeRepository Create(IDietTypeRepository DietType);
        void Delete(Guid Id);
        void Update(Guid Id);
        IDietTypeRepository Get(Guid Id);

    }
}
