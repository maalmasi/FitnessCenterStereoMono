﻿using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Common
{
   public interface ITrainerService
    {
        IEnumerable<ITrainer> Find(IFilter filter);
        ICard Create(ICard card);
        bool Delete(Guid id);
        bool Update(ICard card);
        ICard Get(Guid id);
    }
}
