using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IMemebershipRepository
    {
        Guid GetById(Guid Id);
        float GetByPrice(float Price);
       
    }
}
