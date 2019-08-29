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
            throw new NotImplementedException();
        }

        public PaginatedList<T> Find(TFilter filter)
        {
            IQueryable<TEntity> entities = AppDbContext.Set<TEntity>().AsNoTracking();

            entities = ApplyFilter(entities, filter);

            switch (filter.SortBy.ToLowerInvariant())
            {
                case "name":
                    if (!filter.SortAscending)
                        entities = entities.OrderByDescending(c => c.Name);
                    else
                        entities = entities.OrderBy(c => c.Name);
                    break;

                case "abbreviation":
                    if (!filter.SortAscending)
                        entities = entities.OrderByDescending(c => c.Abbreviation);
                    else
                        entities = entities.OrderBy(c => c.Abbreviation);
                    break;

                case "ingridients":
                    if (!filter.SortAscending)
                        entities = entities.OrderByDescending(c => c.Ingridients);
                    else
                        entities = entities.OrderBy(c => c.Ingridients);
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

            var count = entities.Count();

            var items = entities.Skip((filter.Page - 1) * filter.RecordsPerPage).Take(filter.RecordsPerPage).ToList();

            return new PaginatedList<T>(Mapper.Map<IEnumerable<T>>(items), count, filter.Page, filter.RecordsPerPage);
        }

        public T Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(T model)
        {
            throw new NotImplementedException();
        }

        protected virtual IQueryable<TEntity> ApplyFilter(IQueryable<TEntity> entities, TFilter filter)
        {
            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                entities = entities.Where(c => c.Id.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()));
            }
            return entities;
        }

        #endregion Methods
    }
}