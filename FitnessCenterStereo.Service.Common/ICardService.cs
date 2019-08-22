using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
    public interface ICardService
    {
        IEnumerable<ICard> Find(IFilter filter);
        ICard Create(ICard Card);
        void Delete(Guid Id);
        void Update(Guid Id);
        ICard Get(Guid Id);

    }
}
