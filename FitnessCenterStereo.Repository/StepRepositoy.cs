using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository
{

    class StepRepositoy : IStepRepository
    {
        public IStepRepository Create(IStep step)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IStep> Find(IFilter filter)
        {
            throw new NotImplementedException();
        }

        public IStep Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(IStep step)
        {
            throw new NotImplementedException();
        }
    }
}
