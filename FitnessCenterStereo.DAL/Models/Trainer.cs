using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Trainer : BaseModel
    {
        #region Constructors

        public Trainer()
        {
            Compiles = new HashSet<PlanTrainer>();
        }

        #endregion Constructors

        #region Properties

        public virtual ICollection<PlanTrainer> Compiles { get; set; }

        public string FirstName { get; set; }
        public DateTime? HiredAt { get; set; }

        public string LastName { get; set; }

        #endregion Properties
    }
}