using AutoMapper;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.DAL.Data;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;


namespace FitnessCenterStereo.Repository
{
    public class CardRepository : ICardRepository
    {
        protected ApplicationDbContext appDbContext { get; private set; }
        private readonly IMapper mapper;
        public CardRepository(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            appDbContext = applicationDbContext;
            this.mapper = mapper;

        }
        public ICard Create(ICard card)
        {
            return mapper.Map<ICard>(appDbContext.Card.Add(mapper.Map<Card>(card)));
        }

        public bool Delete(Guid id)
        {
            Card ToDelete = appDbContext.Card.Find(id);
            if (ToDelete != null) { appDbContext.Card.Remove(ToDelete); return true; }
            appDbContext.SaveChanges();
            return false;

        }

        public IEnumerable<ICard> Find(IFilter filter)
        {
            return (IEnumerable<ICard>)appDbContext.Card.Find(filter);
        }

        public ICard Get(Guid id)
        {
            return mapper.Map<ICard>(appDbContext.Card.Find(id));
        }

        public bool Update(ICard card)
        {
            Card ToUpdate = appDbContext.Card.Find(card);
            appDbContext.Card.Update(ToUpdate);
            if (ToUpdate != card) { return true; }

            return false;
        }

        IEnumerable<ICard> ICardRepository.Find(IFilter filter)
        {
            return (IEnumerable<ICard>)appDbContext.Card.Find(filter);
        }

       

    

        
    }
}
