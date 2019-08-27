using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenterStereo.WebApi.Models
{
    public class TrainerViewModel : BaseViewModel
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public DateTime HiredAt { get; set; }
    }
}

