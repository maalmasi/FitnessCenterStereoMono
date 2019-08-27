using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface ICardRepository
    {
        PaginatedList<ICard> Find(IFilter filter);
        ICard Create(ICard bodyPartType);
        bool Delete(Guid id);
        bool Update(ICard card);
        ICard Get(Guid id);

    }
}
