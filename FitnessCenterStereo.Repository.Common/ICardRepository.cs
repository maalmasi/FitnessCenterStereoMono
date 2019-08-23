using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository.Common
{
    public interface ICardRepository
    {
        IEnumerable<ICardRepository> Find(IFilter filter);
        ICardRepository Create(ICardRepository bodyPartType);
        bool Delete(Guid id);
        bool Update(ICardRepository bodyPartType);
        ICardRepository Get(Guid id);

    }
}
