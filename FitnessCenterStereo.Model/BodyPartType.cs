using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model
{
  public  class BodyPartType : IBodyPartType, IBaseModel
    {
        public Guid Id { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }
}
