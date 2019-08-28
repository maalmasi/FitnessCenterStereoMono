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
    class DietTypeRepository : IDietTypeRepository
    {
        protected ApplicationDbContext AppDbContext { get; private set; }
        private readonly IMapper mapper;

        public DietTypeRepository(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            AppDbContext = applicationDbContext;
            this.mapper = mapper;

        }
        public IDietType Create(IDietType dietType)
        {
            dietType.Id = Guid.NewGuid();
            dietType.DateCreated = DateTime.UtcNow;
            dietType.DateUpdated = DateTime.UtcNow;
            AppDbContext.DietType.Add(mapper.Map<DietType>(dietType));
            AppDbContext.SaveChanges();
            return dietType;
        }

        public bool Delete(Guid id)
        {
            var toDelete = AppDbContext.DietType.Find(id);
            AppDbContext.DietType.Remove(toDelete);
            AppDbContext.SaveChanges();
            return AppDbContext.SaveChanges() == 1;

        }

        public PaginatedList<IDietType> Find(IFilter filter)
        {
            IQueryable<DietType> dietType = AppDbContext.DietType.AsNoTracking();

            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                dietType = dietType.Where(c => c.Name.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.Abbreviation.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.Ingridients.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || String.Format("{0:s}", c.DateUpdated).ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || String.Format("{0:s}", c.DateCreated).ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant())|| c.Id.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()));
            }
            switch (filter.SortBy.ToLowerInvariant())
            {
                case "name":
                    if (!filter.SortAscending)
                        dietType = dietType.OrderByDescending(c => c.Name);
                    else
                        dietType = dietType.OrderBy(c => c.Name);
                    break;

                case "abbr":
                    if (!filter.SortAscending)
                        dietType = dietType.OrderByDescending(c => c.Abbreviation);
                    else
                        dietType = dietType.OrderBy(c => c.Abbreviation);
                    break;

                case "ingridients":
                    if (!filter.SortAscending)
                        dietType = dietType.OrderByDescending(c => c.Ingridients);
                    else
                        dietType = dietType.OrderBy(c => c.Ingridients);
                    break;

                case "dateupdated":
                    if (!filter.SortAscending)
                        dietType = dietType.OrderByDescending(c => c.DateUpdated);
                    else
                        dietType = dietType.OrderBy(c => c.DateUpdated);
                    break;

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }

            var count = dietType.Count();

            var items = dietType.Skip((filter.Page - 1) * filter.RecordsPerPage).Take(filter.RecordsPerPage).ToList();


            return new PaginatedList<IDietType>(mapper.Map<IEnumerable<IDietType>>(items), count, filter.Page, filter.RecordsPerPage);
        }

        public IDietType Get(Guid id)
        {
            return mapper.Map<IDietType>(AppDbContext.DietType.Find(id));
        }

        public bool Update(IDietType dietType)
        {
            if (AppDbContext.DietType.Find(dietType).Id == dietType.Id)
            {
                AppDbContext.DietType.Update(mapper.Map<DietType>(dietType));
                return AppDbContext.SaveChanges() == 1;
            }
            return false;

        }
    }
}
