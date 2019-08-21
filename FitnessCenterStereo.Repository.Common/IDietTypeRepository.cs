using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IDietTypeRepository
    {
        Guid GetById(Guid Id);
        String GetByName(String name);
        String GetByAbbreviation(String Abbrevation);
        String GetByIngridients(String Ingirdients);
     
    }
}
