﻿using AutoMapper;
using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.DAL.Data;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Repository.Common;
using System;
using System.Linq;

namespace FitnessCenterStereo.Repository
{
    public class BodyPartTypeRepository : Repository<IBodyPartType, BodyPartType, IBodyPartTypeFilter>, IBodyPartTypeRepository
    {
        #region Constructors

        public BodyPartTypeRepository(ApplicationDbContext appDbContext, IMapper mapper) : base(appDbContext, mapper)
        {
        }

        #endregion Constructors

        #region Methods

        protected override IQueryable<BodyPartType> ApplyFilter(IQueryable<BodyPartType> entities, IBodyPartTypeFilter filter)
        {
            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                entities = entities.Where(c => c.Abbreviation.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.Name.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()));
            }
            return entities;
        }

        protected override IQueryable<BodyPartType> ApplySort(IQueryable<BodyPartType> entities, IBodyPartTypeFilter filter)
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

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }
            return entities;
        }

        #endregion Methods
    }
}