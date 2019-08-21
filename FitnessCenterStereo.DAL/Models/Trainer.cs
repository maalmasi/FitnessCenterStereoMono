using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Trainer
    {
        public Trainer()
        {
            Compiles = new HashSet<Compiles>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? HiredAt { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual ICollection<Compiles> Compiles { get; set; }
    }
}
