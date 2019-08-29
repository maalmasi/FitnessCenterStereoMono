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
    public class StepRepositoy : Repository<IStep, Step, IStepFilter>, IStepRepository
    {
        #region Constructors

        public StepRepositoy(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        #endregion Constructors

        #region Methods

        protected IQueryable<IStep> ApplyFilter(IQueryable<IStep> entities, IStepFilter filter)
        {
            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                entities = entities.Where(c => c.Id.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.Name.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.Description.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()));
            }
            return entities;
        }

        protected IQueryable<IStep> ApplySort(IQueryable<IStep> entities, IStepFilter filter)
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

                case "description":
                    if (!filter.SortAscending)
                        entities = entities.OrderByDescending(c => c.Description);
                    else
                        entities = entities.OrderBy(c => c.Description);
                    break;

                case "abbreaviaton":
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