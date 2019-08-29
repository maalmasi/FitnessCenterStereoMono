using AutoMapper;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.DAL.Data;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FitnessCenterStereo.Repository
{
    public class BodyPartTypeRepository : IBodyPartTypeRepository
    {
        #region Constructors

        public BodyPartTypeRepository(ApplicationDbContext applicationDbContext, IMapper mapperInterface)
        {
            AppDbContext = applicationDbContext;
            Mapper = mapperInterface;
        }

        #endregion Constructors

        #region Properties

        protected ApplicationDbContext AppDbContext { get; private set; }
        protected IMapper Mapper { get; private set; }

        #endregion Properties

        #region Methods

        public IBodyPartType Create(IBodyPartType bodyPartType)
        {
            bodyPartType.Id = Guid.NewGuid();
            bodyPartType.DateCreated = DateTime.UtcNow;
            bodyPartType.DateUpdated = DateTime.UtcNow;
            AppDbContext.BodyPartType.Add(Mapper.Map<BodyPartType>(bodyPartType));
            AppDbContext.SaveChanges();
            return bodyPartType;
        }

        public bool Delete(Guid id)
        {
            var toDelete = AppDbContext.BodyPartType.Find(id);
            AppDbContext.BodyPartType.Remove(toDelete);
            return AppDbContext.SaveChanges() == 1;
        }

        public PaginatedList<IBodyPartType> Find(IFilter filter)
        {
            IQueryable<BodyPartType> bodyPartType = AppDbContext.BodyPartType.AsNoTracking();

            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                bodyPartType = bodyPartType.Where(bpt => bpt.Name.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || bpt.Abbreviation.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || bpt.Id.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || String.Format("{0:s}", bpt.DateCreated).ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || String.Format("{0:s}", bpt.DateUpdated).ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()));
            }

            switch (filter.SortBy.ToLowerInvariant())
            {
                case "name":
                    if (!filter.SortAscending)
                        bodyPartType = bodyPartType.OrderByDescending(bpt => bpt.Name);
                    else
                        bodyPartType = bodyPartType.OrderBy(bpt => bpt.Name);

                    break;

                case "abbreviation":
                    if (!filter.SortAscending)
                        bodyPartType = bodyPartType.OrderByDescending(bpt => bpt.Abbreviation);
                    else
                        bodyPartType = bodyPartType.OrderBy(bpt => bpt.Abbreviation);
                    break;

                case "dateupdated":
                    if (!filter.SortAscending)
                        bodyPartType = bodyPartType.OrderByDescending(bpt => bpt.DateUpdated);
                    else
                        bodyPartType = bodyPartType.OrderBy(bpt => bpt.DateUpdated);
                    break;

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }

            var count = bodyPartType.Count();

            var items = bodyPartType.Skip((filter.Page - 1) * filter.RecordsPerPage).Take(filter.RecordsPerPage).ToList();

            return new PaginatedList<IBodyPartType>(Mapper.Map<IEnumerable<IBodyPartType>>(items), count, filter.Page, filter.RecordsPerPage);
        }

        public IBodyPartType Get(Guid id)
        {
            return Mapper.Map<IBodyPartType>(AppDbContext.BodyPartType.Find(id));
        }

        public bool Update(IBodyPartType bodyPartType)
        {
            if (AppDbContext.BodyPartType.Find(bodyPartType.Id) != null)
            {
                AppDbContext.BodyPartType.Update(Mapper.Map<BodyPartType>(bodyPartType));
                return AppDbContext.SaveChanges() == 1;
            }
            return false;
        }

        #endregion Methods
    }
}