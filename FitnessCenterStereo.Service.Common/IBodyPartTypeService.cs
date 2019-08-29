using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Service.Common
{
    public interface IBodyPartTypeService
    {
        #region Methods

        IBodyPartType Create(IBodyPartType bodyPartType);

        bool Delete(Guid id);

        PaginatedList<IBodyPartType> Find(IBodyPartTypeFilter filter);

        IBodyPartType Get(Guid id);

        bool Update(IBodyPartType bodyPartType);

        #endregion Methods
    }
}