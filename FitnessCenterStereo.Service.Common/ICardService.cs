using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface ICardService
    {
        Guid GetById(Guid id);
        Guid GetByMembershipId(Guid Id);
        String GetByUserId(Guid Id);
    }
}
