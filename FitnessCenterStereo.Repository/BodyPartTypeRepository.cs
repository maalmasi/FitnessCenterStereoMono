using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.DAL.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;

namespace FitnessCenterStereo.Repository
{
    public class BodyPartTypeRepository : IBodyPartTypeRepository
    {
        protected ApplicationDbContext AppDbContext { get; private set; }
        protected IMapper Mapper { get; private set; }

        public BodyPartTypeRepository(ApplicationDbContext applicationDbContext, IMapper mapperInterface)
        {
            AppDbContext = applicationDbContext;
            Mapper = mapperInterface;
        }

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
                               //select bpt;

            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                bodyPartType = bodyPartType.Where(bpt => bpt.Name.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || bpt.Abbreviation.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()));
            }

            switch (filter.SortBy.ToLowerInvariant())
            {
                case "name":
                    if (!filter.SortAscending)
                        bodyPartType = bodyPartType.OrderByDescending(bpt => bpt.Name);
                    else
                        bodyPartType = bodyPartType.OrderBy(bpt => bpt.Name);

                    break;
                case "abbr":
                    if (!filter.SortAscending)
                        bodyPartType = bodyPartType.OrderByDescending(bpt => bpt.Abbreviation);
                    else
                        bodyPartType = bodyPartType.OrderBy(bpt => bpt.Abbreviation);
                    break;

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }
            
            var count = bodyPartType.Count();

            var items = bodyPartType.Skip((filter.Page - 1) * filter.RecordsPerPage).Take(filter.RecordsPerPage).ToList();


            return new PaginatedList<IBodyPartType>(Mapper.Map<IEnumerable<IBodyPartType>>(items), count, filter.Page, filter.RecordsPerPage) ;
        }

        public IBodyPartType Get(Guid id)
        {
            return Mapper.Map<IBodyPartType>(AppDbContext.BodyPartType.Find(id));
        }

        public bool Update(IBodyPartType bodyPartType)
        {
            AppDbContext.BodyPartType.Update(Mapper.Map<BodyPartType>(bodyPartType));
            return AppDbContext.SaveChanges() == 1;
        }


    }
}
