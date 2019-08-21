using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenterStereo.WebApi.Models
{
    public class CardViewModel
    {
        public Guid Id { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid MembershipId { get; set; }
        public string UserId { get; set; }
    }
}
