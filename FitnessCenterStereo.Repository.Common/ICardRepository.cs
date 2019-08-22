using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface ICardRepository
    {
        IEnumerable<ICardRepository> Find(IFilter filter);
        ICardRepository Create(ICardRepository CardRepository);
        void Delete(Guid Id);
        void Update(Guid Id);
        ICardRepository Get(Guid Id);

    }
}
