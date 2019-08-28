﻿using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
    public interface IMembershipService
    {
        PaginatedList<IMembership> Find(IFilter filter);
        IMembership Create(IMembership membership);
        bool Delete(Guid id);
        bool Update(IMembership membership);
        IMembership Get(Guid id);
    }
}
