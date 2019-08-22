using FitnessCenterStereo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface ICardService
    {
        IEnumerable<ICardService> Find(IFilter filter);
        ICardService Create(ICardService Card);
        void Delete(Guid Id);
        void Update(Guid Id);
        ICardService Get(Guid Id);

    }
}
