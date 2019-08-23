using FitnessCenterStereo.Common;
using FitnessCenterStereo.Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository
{
    class TrainerRepository : ITrainerRepository
    {
        public ITrainerRepository Create(ITrainerRepository bodyPartType)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITrainerRepository> Find(IFilter filter)
        {
            throw new NotImplementedException();
        }

        public ITrainerRepository Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ITrainerRepository bodyPartType)
        {
            throw new NotImplementedException();
        }
    }
}
