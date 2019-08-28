using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace FitnessCenterStereo.WebApi.Models
{
    public abstract class BaseViewModel
    {
        
        public Guid Id { get; set; }
      
        public DateTime DateUpdated { get; set; }
       
        public DateTime DateCreated { get; set; }
    }
}
