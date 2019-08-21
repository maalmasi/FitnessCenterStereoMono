using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenterStereo.WebApi.Models
{
    public class TrainerViewModel
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public DateTime HiredAt { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}

