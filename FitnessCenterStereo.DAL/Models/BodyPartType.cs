using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class BodyPartType
    {
        #region Constructors

        public BodyPartType()
        {
            Exercises = new HashSet<Exercises>();
        }

        #endregion Constructors

        #region Properties

        public string Abbreviation { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public virtual ICollection<Exercises> Exercises { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }

        #endregion Properties
    }
}