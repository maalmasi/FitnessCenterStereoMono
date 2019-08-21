using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IDietType : IBaseModel
    {
       
        String Name { get; set; }
        String Abbreviation { get; set; }
        String Ingridients { get; set; }
        
    }
}
