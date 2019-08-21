using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common
{
    public interface ICard
    {
        
        Guid MembershipId { get; set; }
        String UserId { get; set; }
   
    }
}
