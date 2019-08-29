using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Service.Common
{
    public interface ICardService
    {
        #region Methods

        ICard Create(ICard card);

        bool Delete(Guid id);

        PaginatedList<ICard> Find(ICardFilter filter);

        ICard Get(Guid id);

        bool Update(ICard card);

        #endregion Methods
    }
}