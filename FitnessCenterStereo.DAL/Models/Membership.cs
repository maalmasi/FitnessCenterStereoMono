using System;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Membership
    {
        #region Properties

        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public Guid Id { get; set; }
        public decimal? Price { get; set; }

        #endregion Properties
    }
}