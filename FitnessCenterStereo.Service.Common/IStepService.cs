using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
   public interface IStepService
    {
         Guid GetById(Guid Id);
        String GetByName(String Name);
        String GetByAbbreviatio(String Description);
        Guid ExercisesId { get; set; }
    }
}
