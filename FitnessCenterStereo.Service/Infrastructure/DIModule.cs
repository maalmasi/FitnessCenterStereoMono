using Autofac;
using FitnessCenterStereo.Service.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Service.Infrastructure
{
    public class DIModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BodyPartTypeService>().As<IBodyPartTypeService>();
        }
    }
}
