using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
   public interface ITrainerService
    {
        Guid GetById(Guid Id);
        String GetByFirstName(String FirstName);
        String GetByLastName(String LastName);
        DateTime GetByHiredAt(DateTime HiredAt);
    }
}
