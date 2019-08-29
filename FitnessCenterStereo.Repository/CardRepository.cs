using AutoMapper;
using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.DAL.Data;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Model.Common;
using System;
using System.Linq;

namespace FitnessCenterStereo.Repository
{
    public class CardRepository : Repository<ICard, Card, ICardFilter>
    {
        #region Constructors

        public CardRepository(ApplicationDbContext appDbContext, IMapper mapper) : base(appDbContext, mapper)
        {
        }

        #endregion Constructors

        #region Methods

        protected IQueryable<ICard> ApplyFilter(IQueryable<ICard> entities, ICardFilter filter)
        {
            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                entities = entities.Where(c => c.Id.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.Abbreviation.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.Name.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()));
            }
            return entities;
        }

        protected IQueryable<ICard> ApplySort(IQueryable<ICard> entities, ICardFilter filter)
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

                case "userid":
                    if (!filter.SortAscending)
                        entities = entities.OrderByDescending(c => c.UserId);
                    else
                        entities = entities.OrderBy(c => c.UserId);
                    break;

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }
            return entities;
        }

        #endregion Methods
    }
}