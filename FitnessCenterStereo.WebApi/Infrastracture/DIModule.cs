using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using System.Threading.Tasks;
using FitnessCenterStereo.Common;

namespace FitnessCenterStereo.WebApi.Infrastracture
{
    public class DIModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Filter>().As<IFilter>();

   
        }
    }
}
