using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.Service
{
    class CardService : ICardService
    {
        public CardService(ICardRepository cardRepository)
        {
            CardRepository = cardRepository;
        }

        public ICardRepository CardRepository { get; private set; }

        public ICard Create(ICard card)
        {
            return CardRepository.Create(card);
        }

        public bool Delete(Guid id)
        {
            if (CardRepository.Delete(id))
                return true;
            else return false;
        }

        public IEnumerable<ICard> Find(IFilter filter)
        {
            return CardRepository.Find(filter);
        }

        public ICard Get(Guid id)
        {
            return CardRepository.Get(id);
        }

        public bool Update(ICard card)
        {
            if (CardRepository.Update(card))
                return true;
            else return false;
        }
    }
}
