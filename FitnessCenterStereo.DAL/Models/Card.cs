using Microsoft.AspNetCore.Identity;
using System;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Card
    {
        #region Properties

        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public Guid Id { get; set; }
        public Guid? MembershipId { get; set; }
        public virtual IdentityUser User { get; set; }
        public string UserId { get; set; }

        #endregion Properties
    }
}