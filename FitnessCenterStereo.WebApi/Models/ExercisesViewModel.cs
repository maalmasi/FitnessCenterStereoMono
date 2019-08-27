using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenterStereo.WebApi.Models
{
    public class ExercisesViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public Guid BodyPartId { get; set; }
        public Guid ComplexityLevelTypeId { get; set; }
    }
}
