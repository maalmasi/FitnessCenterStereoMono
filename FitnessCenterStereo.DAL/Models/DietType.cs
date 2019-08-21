using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class DietType
    {
        public DietType()
        {
            Plan = new HashSet<Plan>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Abbreaviaton { get; set; }
        public string Ingridients { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual ICollection<Plan> Plan { get; set; }
    }
}
