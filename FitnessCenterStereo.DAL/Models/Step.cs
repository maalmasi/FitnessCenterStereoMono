using System;

namespace FitnessCenterStereo.DAL.Models
{
    public partial class Step
    {
        #region Properties

        public string Abbreaviaton { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string Description { get; set; }
        public virtual Exercises Exercises { get; set; }
        public Guid? ExercisesId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }

        #endregion Properties
    }
}