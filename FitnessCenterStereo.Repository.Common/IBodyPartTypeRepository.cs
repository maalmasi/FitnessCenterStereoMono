using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IBodyPartTypeRepository
    {

        PaginatedList<IBodyPartType> Find(IFilter filter);
        IBodyPartType Create(IBodyPartType bodyPartType);
        bool Delete(Guid id);
        bool Update(IBodyPartType bodyPartType);
        IBodyPartType Get(Guid id);

    }
}
