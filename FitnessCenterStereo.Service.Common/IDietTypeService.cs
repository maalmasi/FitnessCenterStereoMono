using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Service.Common
{
    public interface IDietTypeService
    {
        PaginatedList<IDietType> Find(IFilter filter);
        IDietType Create(IDietType dietType);
        bool Delete(Guid id);
        bool Update(IDietType dietType);
        IDietType Get(Guid id);
    }
}
