using FitnessCenterStereo.Common;
using FitnessCenterStereo.Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository
{

    class StepRepositoy : IStepRepository
    {
        public IStepRepository Create(IStepRepository bodyPartType)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IStepRepository> Find(IFilter filter)
        {
            throw new NotImplementedException();
        }

        public IStepRepository Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(IStepRepository bodyPartType)
        {
            throw new NotImplementedException();
        }
    }
}
