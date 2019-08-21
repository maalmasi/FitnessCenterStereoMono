using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class ComplexityLevelType
    {
        public ComplexityLevelType()
        {
            Exercises = new HashSet<Exercises>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual ICollection<Exercises> Exercises { get; set; }
    }
}
