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
            builder.RegisterType<CardService>().As<ICardService>();
            builder.RegisterType<ComplexityLevelTypeService>().As<IComplexityLevelTypeService>();
            builder.RegisterType<DietTypeService>().As<IDietTypeService>();
            builder.RegisterType<EquipmentService>().As<IEquipmentService>();
            builder.RegisterType<ExerciseEquipmentService>().As<IExerciseEquipmentService>();
            builder.RegisterType<ExerciseScheduleService>().As<IExerciseScheduleService>();
            builder.RegisterType<ExercisesService>().As<IExercisesService>();
            builder.RegisterType<MembershipService>().As<IMembershipService>();
            builder.RegisterType<PlanService>().As<IPlanService>();
            builder.RegisterType<PlanTrainerService>().As<IPlanTrainerService>();
            builder.RegisterType<ScheduleService>().As<IScheduleService>();
            builder.RegisterType<StepService>().As<IStepService>();
            builder.RegisterType<TrainerService>().As<ITrainerService>();
        }
    }
}
