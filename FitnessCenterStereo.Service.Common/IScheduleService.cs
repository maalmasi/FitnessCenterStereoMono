using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IScheduleService
    {
        Guid GetById(Guid Id);
        int GetByFrequency(int Frequency);
    }
}
