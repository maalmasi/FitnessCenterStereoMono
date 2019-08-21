using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface IBaseModel
    {
        Guid Id { get; set; }
        DateTime DateUpdated { get; set; }
        DateTime DateCreated { get; set; }
    }
}
