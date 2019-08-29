using AutoMapper;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.DAL.Data;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FitnessCenterStereo.Repository
{
    public class Repository<T, TEntity, TFilter> : IRepository<T, TEntity, TFilter>
        where T : IBaseModel
        where TEntity : BaseModel
        where TFilter : IFilter
    {
        #region Constructors

        public Repository(ApplicationDbContext appDbContext, IMapper mapper)
        {
            AppDbContext = appDbContext;
            Mapper = mapper;
        }

        #endregion Constructors

        #region Properties

        protected ApplicationDbContext AppDbContext { get; private set; }
        protected IMapper Mapper { get; private set; }

        #endregion Properties

        #region Methods

        public T Create(T model)
        {
            model.Id = Guid.NewGuid();
            model.DateCreated = DateTime.UtcNow;
            model.DateUpdated = DateTime.UtcNow;
            AppDbContext.Set<TEntity>().Add(Mapper.Map<TEntity>(model));
            AppDbContext.SaveChanges();
            return model;
        }

        public bool Delete(Guid id)
        {
            var toDelete = AppDbContext.Set<TEntity>().Find(id);
            AppDbContext.Set<TEntity>().Remove(toDelete);
            return AppDbContext.SaveChanges() == 1;
        }

        public PaginatedList<T> Find(TFilter filter)
        {
            IQueryable<TEntity> entities = AppDbContext.Set<TEntity>().AsNoTracking();

            entities = ApplyFilter(entities, filter);
            entities = ApplySort(entities, filter);

            var count = entities.Count();

            var items = entities.Skip((filter.Page - 1) * filter.RecordsPerPage).Take(filter.RecordsPerPage).ToList();

            return new PaginatedList<T>(Mapper.Map<IEnumerable<T>>(items), count, filter.Page, filter.RecordsPerPage);
        }

        public T Get(Guid id)
        {
            return Mapper.Map<T>(AppDbContext.Set<TEntity>().Find(id));
        }

        public bool Update(T model)
        {
            if (AppDbContext.Set<TEntity>().Find(model.Id) != null)
            {
                AppDbContext.Set<TEntity>().Update(Mapper.Map<TEntity>(model));
                return AppDbContext.SaveChanges() == 1;
            }
            return false;
        }

        protected virtual IQueryable<TEntity> ApplyFilter(IQueryable<TEntity> entities, TFilter filter)
        {
            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                entities = entities.Where(c => c.Id.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()));
            }
            return entities;
        }

        protected virtual IQueryable<TEntity> ApplySort(IQueryable<TEntity> entities, TFilter filter)
        {
            switch (filter.SortBy.ToLowerInvariant())
            {
                case "datecreated":
                    if (!filter.SortAscending)
                        entities = entities.OrderByDescending(c => c.DateCreated);
                    else
                        entities = entities.OrderBy(c => c.DateCreated);
                    break;

                case "dateupdated":
                    if (!filter.SortAscending)
                        entities = entities.OrderByDescending(c => c.DateUpdated);
                    else
                        entities = entities.OrderBy(c => c.DateUpdated);
                    break;

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }
            return entities;
        }

        #endregion Methods
    }
}