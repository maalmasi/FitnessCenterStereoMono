using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenterStereo.WebApi.Models
{
    public class ExerciseEquipmentViewModel : BaseViewModel
    {
        public Guid ExerciseId { get; set; }
        public Guid EquipmentId { get; set; }
    }
}
