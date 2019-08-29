using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;

namespace FitnessCenterStereo.Service
{
    public class CardService : ICardService
    {
        #region Constructors

        public CardService(ICardRepository cardRepository)
        {
            CardRepository = cardRepository;
        }

        #endregion Constructors

        #region Properties

        public ICardRepository CardRepository { get; private set; }

        #endregion Properties

        #region Methods

        public ICard Create(ICard card)
        {
            return CardRepository.Create(card);
        }

        public bool Delete(Guid id)
        {
            return CardRepository.Delete(id);
        }

        public PaginatedList<ICard> Find(ICardFilter filter)
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

        #endregion Methods
    }
}