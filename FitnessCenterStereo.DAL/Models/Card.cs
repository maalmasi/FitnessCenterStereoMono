using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Card
    {
        public Guid Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public Guid? MembershipId { get; set; }
        public string UserId { get; set; }

        public virtual IdentityUser User { get; set; }
    }
}
