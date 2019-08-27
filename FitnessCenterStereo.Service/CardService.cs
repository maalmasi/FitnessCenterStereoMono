using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
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
            return CardRepository.Delete(id);
        }

        public PaginatedList<ICard> Find(IFilter filter)
        {
            return CardRepository.Find(filter);
        }

        public ICard Get(Guid id)
        {
            return CardRepository.Get(id);
        }

        public bool Update(ICard card)
        {
            return CardRepository.Update(card);
        }
    }
}
