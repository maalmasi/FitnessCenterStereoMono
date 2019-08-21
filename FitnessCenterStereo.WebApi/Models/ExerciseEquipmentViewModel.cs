using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenterStereo.WebApi.Models
{
    public class ExerciseEquipmentViewModel
    {
        public Guid ExerciseId { get; set; }
        public Guid EquipmentId { get; set; }
        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        public Guid ExerciseEquipmentId { get; set; }
        public Guid Id { get; set; }
    }
}
