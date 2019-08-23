using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Plan
    {
        public Plan()
        {
            Users = new HashSet<IdentityUser>();
            Compiles = new HashSet<PlanTrainer>();
            Schedule = new HashSet<Schedule>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public Guid? DietTypeId { get; set; }

        public virtual DietType DietType { get; set; }
        public virtual ICollection<IdentityUser> Users { get; set; }
        public virtual ICollection<PlanTrainer> Compiles { get; set; }
        public virtual ICollection<Schedule> Schedule { get; set; }
    }
}
