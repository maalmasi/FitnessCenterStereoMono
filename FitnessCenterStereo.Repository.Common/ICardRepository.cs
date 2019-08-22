using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface ICardRepository
    {
        IEnumerable<ICard> Find(IFilter filter);
        ICard Create(ICard CardRepository);
        void Delete(Guid Id);
        void Update(Guid Id);
        ICard Get(Guid Id);

    }
}
