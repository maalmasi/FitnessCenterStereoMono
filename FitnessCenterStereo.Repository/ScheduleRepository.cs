using FitnessCenterStereo.Common;
using FitnessCenterStereo.Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository
{

    class ScheduleRepository : IScheduleRepository
    {
        public IScheduleRepository Create(IScheduleRepository bodyPartType)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IScheduleRepository> Find(IFilter filter)
        {
            throw new NotImplementedException();
        }

        public IScheduleRepository Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(IScheduleRepository bodyPartType)
        {
            throw new NotImplementedException();
        }
    }
}
