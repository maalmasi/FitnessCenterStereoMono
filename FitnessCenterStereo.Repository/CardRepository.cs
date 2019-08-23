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
        public CardRepository(ApplicationDbContext applicationDbContext)
        {
            appDbContext = applicationDbContext;

        }
        public ICard Create(ICard card)
        {
            return (ICard)appDbContext.Card.Add(new Card());
        }

        public bool Delete(Guid id)
        {
            Card ToDelete = appDbContext.Card.Find(id);
            if (ToDelete != null) { appDbContext.Card.Remove(ToDelete); return true; }

            return false;

        }

        public IEnumerable<ICard> Find(IFilter filter)
        {
            return (IEnumerable<ICard>)appDbContext.Card.Find(filter);
        }

        public ICard Get(Guid id)
        {
            ICard card = (ICard)appDbContext.Card.Find(id);
            return card;
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
            throw new NotImplementedException();
        }

       

    

        
    }
}
