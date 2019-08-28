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
using System.Text;

namespace FitnessCenterStereo.Repository
{
    class MembershipRepository : IMembershipRepository
    {
        protected ApplicationDbContext AppDbContext { get; private set; }
        private readonly IMapper mapper;

        public MembershipRepository(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            AppDbContext = applicationDbContext;
            this.mapper = mapper;

        }
        public IMembership Create(IMembership membership)
        {
            membership.Id = Guid.NewGuid();
            membership.DateCreated = DateTime.UtcNow;
            membership.DateUpdated = DateTime.UtcNow;
            AppDbContext.Membership.Add(mapper.Map<Membership>(membership));
            AppDbContext.SaveChanges();
            return membership;
        }

        public bool Delete(Guid id)
        {
            var toDelete = AppDbContext.Membership.Find(id);
            AppDbContext.Membership.Remove(toDelete);
            AppDbContext.SaveChanges();
            return AppDbContext.SaveChanges() == 1;

        }

        public PaginatedList<IMembership> Find(IFilter filter)
        {
            IQueryable<Membership> membership = AppDbContext.Membership.AsNoTracking();

            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                membership = membership.Where(c => c.Price.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.Id.ToString().ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || String.Format("{0:s}",c.DateCreated).ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || String.Format("{0:s}",c.DateUpdated).ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()));
            }
            switch (filter.SortBy.ToLowerInvariant())
            {
                case "price":
                    if (!filter.SortAscending)
                        membership = membership.OrderByDescending(c => c.Price);
                    else
                        membership = membership.OrderBy(c => c.Price);

                    break;
                case "dateupdated":
                    if (!filter.SortAscending)
                        membership = membership.OrderByDescending(c => c.DateUpdated);
                    else
                        membership = membership.OrderBy(c => c.DateUpdated);

                    break;
                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }

            var count = membership.Count();

            var items = membership.Skip((filter.Page - 1) * filter.RecordsPerPage).Take(filter.RecordsPerPage).ToList();


            return new PaginatedList<IMembership>(mapper.Map<IEnumerable<IMembership>>(items), count, filter.Page, filter.RecordsPerPage);
        }

        public IMembership Get(Guid id)
        {
            return mapper.Map<IMembership>(AppDbContext.Membership.Find(id));
        }

        public bool Update(IMembership membership)
        {
            if (AppDbContext.Membership.Find(membership).Id == membership.Id)
            {
                AppDbContext.Membership.Update(mapper.Map<Membership>(membership));
                return AppDbContext.SaveChanges() == 1;
            }
            return false;
        }
    }
}
