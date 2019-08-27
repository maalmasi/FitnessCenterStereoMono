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
    public class CardRepository : ICardRepository
    {
        protected ApplicationDbContext AppDbContext { get; private set; }
        private readonly IMapper mapper;
        public CardRepository(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            AppDbContext = applicationDbContext;
            this.mapper = mapper;

        }
        public ICard Create(ICard card)
        {
            card.Id = Guid.NewGuid();
            card.DateCreated = DateTime.UtcNow;
            card.DateUpdated = DateTime.UtcNow;
            AppDbContext.Card.Add(mapper.Map<Card>(card));
            AppDbContext.SaveChanges();
            return card;
        }

        public bool Delete(Guid id)
        {
            var toDelete = AppDbContext.Card.Find(id);
            AppDbContext.Card.Remove(toDelete);
            AppDbContext.SaveChanges();
            return AppDbContext.SaveChanges() == 1;

        }

        public PaginatedList<ICard> Find(IFilter filter)
        {
            IQueryable<Card> card = AppDbContext.Card.AsNoTracking();

            if (!String.IsNullOrEmpty(filter.SearchQuery))
            {
                card = card.Where(c => c.UserId.ToUpperInvariant().Contains(filter.SearchQuery.ToUpperInvariant()) || c.MembershipId.ToString().Contains(filter.SearchQuery));
            }

            switch (filter.SortBy.ToLowerInvariant())
            {
                case "userid":
                    if (!filter.SortAscending)
                        card = card.OrderByDescending(c => c.UserId);
                    else
                        card = card.OrderBy(c => c.UserId);

                    break;
                case "membershipid":
                    if (!filter.SortAscending)
                        card = card.OrderByDescending(c => c.MembershipId);
                    else
                        card = card.OrderBy(c => c.MembershipId);
                    break;

                default:
                    throw new Exception($"Unknown column {filter.SortBy}");
            }

            var count = card.Count();

            var items = card.Skip((filter.Page - 1) * filter.RecordsPerPage).Take(filter.RecordsPerPage).ToList();


            return new PaginatedList<ICard>(mapper.Map<IEnumerable<ICard>>(items), count, filter.Page, filter.RecordsPerPage);
        }

        public ICard Get(Guid id)
        {
            return mapper.Map<ICard>(AppDbContext.Card.Find(id));
        }

        public bool Update(ICard card)
        {
            if (AppDbContext.Card.Find(card).Id == card.Id)
            {
                AppDbContext.Card.Update(mapper.Map<Card>(card));
                return AppDbContext.SaveChanges() == 1;
            }
            else return false;

        }
    }
}
