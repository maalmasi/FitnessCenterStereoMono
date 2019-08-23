using Autofac;
using AutoMapper;
using FitnessCenterStereo.DAL.Data;
using FitnessCenterStereo.Repository.Common;

namespace FitnessCenterStereo.Repository.Infrastructurre
{
    public class DIModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDbContext>().AsSelf();

            builder.RegisterType<IMapper>().AsSelf();

            builder.RegisterType<BodyPartTypeRepository>().As<IBodyPartTypeRepository>();

        }
    }
}
