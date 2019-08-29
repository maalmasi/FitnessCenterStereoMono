using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IRepository<T, TEntity, TFilter>
        where T : IBaseModel
        where TEntity : class
        where TFilter : IFilter

    {
        #region Methods

        T Create(T model);

        bool Delete(Guid id);

        PaginatedList<T> Find(TFilter filter);

        T Get(Guid id);

        bool Update(T model);

        #endregion Methods
    }
}