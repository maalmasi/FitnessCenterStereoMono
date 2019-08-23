﻿using FitnessCenterStereo.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model
{
    public class Trainer : BaseModel, IBodyPartType
    {
     
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public DateTime HiredAt { get; set; }
       
    }
}
