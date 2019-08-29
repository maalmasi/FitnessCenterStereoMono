using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IBodyPartTypeRepository
    {
        #region Methods

        IBodyPartType Create(IBodyPartType bodyPartType);

        bool Delete(Guid id);

        PaginatedList<IBodyPartType> Find(IFilter filter);

        IBodyPartType Get(Guid id);

        bool Update(IBodyPartType bodyPartType);

        #endregion Methods
    }
}