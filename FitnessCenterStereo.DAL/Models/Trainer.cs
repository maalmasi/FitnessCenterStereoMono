using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Trainer
    {
        #region Constructors

        public Trainer()
        {
            Compiles = new HashSet<PlanTrainer>();
        }

        #endregion Constructors

        #region Properties

        public virtual ICollection<PlanTrainer> Compiles { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string FirstName { get; set; }
        public DateTime? HiredAt { get; set; }
        public Guid Id { get; set; }
        public string LastName { get; set; }

        #endregion Properties
    }
}