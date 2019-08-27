using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenterStereo.WebApi.Models
{
    public class CardViewModel : BaseViewModel
    {
        public Guid MembershipId { get; set; }
        public string UserId { get; set; }
    }
}
