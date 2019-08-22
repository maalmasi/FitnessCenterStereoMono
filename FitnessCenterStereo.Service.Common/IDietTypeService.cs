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
        IDietType Create(IDietType DietType);
        void Delete(Guid Id);
        void Update(Guid Id);
        IDietType Get(Guid Id);
    }
}
