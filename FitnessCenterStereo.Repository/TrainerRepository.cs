using AutoMapper;
using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.DAL.Data;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Repository.Common;
using System;
using System.Linq;

namespace FitnessCenterStereo.Repository
{
    internal class TrainerRepository : Repository<ITrainer, Trainer, ITrainerFilter>, ITrainerRepository
    {
        #region Constructors

        public TrainerRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        #endregion Constructors

        #region Methods

        protected IQueryable<ITrainer> ApplyFilter(IQueryable<ITrainer> entities, ITrainerFilter filter)
        {
            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                entities = entities.Where(c => c.Id.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.Firstname.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.LastName.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()));
            }
            return entities;
        }

        protected IQueryable<ITrainer> ApplySort(IQueryable<ITrainer> entities, ITrainerFilter filter)
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

                case "firstname":
                    if (!filter.SortAscending)
                        entities = entities.OrderByDescending(c => c.Firstname);
                    else
                        entities = entities.OrderBy(c => c.Firstname);
                    break;

                case "lastname":
                    if (!filter.SortAscending)
                        entities = entities.OrderByDescending(c => c.LastName);
                    else
                        entities = entities.OrderBy(c => c.LastName);
                    break;

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }
            return entities;
        }

        #endregion Methods
    }
}