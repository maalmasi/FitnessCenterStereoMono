using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenterStereo.WebApi.Models
{
    public class ExercisesViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Guid BodyPartId { get; set; }
        public Guid ComplexityLevelTypeId { get; set; }
    }
}
