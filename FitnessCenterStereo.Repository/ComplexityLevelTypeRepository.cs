using System;
using System.Collections.Generic;
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
    class ComplexityLevelTypeRepository : IComplexityLevelTypeRepository
    {
        protected ApplicationDbContext AppDbContext { get; private set; }
        private readonly IMapper Mapper;
        public ComplexityLevelTypeRepository(ApplicationDbContext applicationDbContext,IMapper mapper)
        {
            AppDbContext = applicationDbContext;
           Mapper = mapper;
        }

        public PaginatedList<IComplexityLevelType> Find(IFilter filter)
        {
            IQueryable<ComplexityLevelType> complexityLevel = AppDbContext.ComplexityLevelType.AsNoTracking();
            //select bpt;

            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                complexityLevel = complexityLevel.Where(cmp => cmp.Name.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || cmp.Abbreviation.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()));
            }

            switch (filter.SortBy.ToLowerInvariant())
            {
                case "name":
                    if (!filter.SortAscending)
                        complexityLevel = complexityLevel.OrderByDescending(cmp => cmp.Name);
                    else
                        complexityLevel = complexityLevel.OrderBy(cmp => cmp.Name);

                    break;
                case "abbr":
                    if (!filter.SortAscending)
                        complexityLevel = complexityLevel.OrderByDescending(cmp => cmp.Abbreviation);
                    else
                        complexityLevel = complexityLevel.OrderBy(cmp => cmp.Abbreviation);
                    break;

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }

            var count = complexityLevel.Count();

            var items = complexityLevel.Skip((filter.Page - 1) * filter.RecordsPerPage).Take(filter.RecordsPerPage).ToList();


            return new PaginatedList<IComplexityLevelType>(Mapper.Map<IEnumerable<IComplexityLevelType>>(items), count, filter.Page, filter.RecordsPerPage);

        }

        public IComplexityLevelType Create(IComplexityLevelType complexityLevel)
        {
            complexityLevel.Id = Guid.NewGuid();
            complexityLevel.DateCreated = DateTime.UtcNow;
            complexityLevel.DateUpdated = DateTime.UtcNow;
            AppDbContext.ComplexityLevelType.Add(Mapper.Map<ComplexityLevelType>(complexityLevel));
            AppDbContext.SaveChanges();
            return complexityLevel;
        }

        public bool Delete(Guid id)
        {
            var toDelete = AppDbContext.ComplexityLevelType.Find(id);
            AppDbContext.ComplexityLevelType.Remove(toDelete);
            return AppDbContext.SaveChanges() == 1;
        }

        public bool Update(IComplexityLevelType complexityLevel)
        {
            AppDbContext.ComplexityLevelType.Update(Mapper.Map<ComplexityLevelType>(complexityLevel));
            return AppDbContext.SaveChanges() == 1;
        }

        public IComplexityLevelType Get(Guid id)
        {
            return Mapper.Map<IComplexityLevelType>(AppDbContext.ComplexityLevelType.Find(id));
        }

       
    }
}
