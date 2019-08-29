using System;

namespace FitnessCenterStereo.WebApi.Models
{
    public class ExerciseEquipmentViewModel : BaseViewModel
    {
        #region Properties

        public Guid EquipmentId { get; set; }
        public Guid ExerciseId { get; set; }

        #endregion Properties
    }
}