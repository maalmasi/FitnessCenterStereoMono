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

        public IEnumerable<IBodyPartType> Find(IFilter filter)
        {

            var bodyPartType = from bpt in AppDbContext.BodyPartType
                               select bpt;

            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                bodyPartType = bodyPartType.Where(bpt => bpt.Name.Contains(filter.SearchQuery) || bpt.Abbreviation.Contains(filter.SearchQuery));
            }

            if (filter.Page < 1) filter.Page = 1;
            if (filter.RecordsPerPage < 10 ) filter.RecordsPerPage = 10;
            if (filter.RecordsPerPage > 100) filter.RecordsPerPage = 100;




            switch (filter.SortBy)
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
                    //Error throw
                    break;
            }

            IQueryable<BodyPartType> bptPaging = bodyPartType.AsNoTracking();
            var count = bptPaging.Count();
            var items = bptPaging.Skip((filter.Page - 1) * filter.RecordsPerPage).Take(filter.RecordsPerPage).ToList();

            return Mapper.Map<IEnumerable<IBodyPartType>>(items);
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
