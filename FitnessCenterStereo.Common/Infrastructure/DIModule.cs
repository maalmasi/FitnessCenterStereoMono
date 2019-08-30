using Autofac;
using Autofac.Extras.AggregateService;
using FitnessCenterStereo.Common.Filters;

namespace FitnessCenterStereo.Common.Infrastructure
{
    internal class DIModule : Module
    {
        #region Methods

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAggregateService<IAggregateService>();
            //builder.Register(c => new ConfigReader("mysection")).As<IConfigReader>();
            builder.Register(c => new BodyPartTypeFilter()).As<IBodyPartTypeFilter>();
            builder.Register(c => new CardFilter()).As<ICardFilter>();
            builder.Register(c => new ComplexityLevelTypeFilter()).As<IComplexityLevelTypeFilter>();
            builder.Register(c => new DietTypeFilter()).As<IDietTypeFilter>();
            builder.Register(c => new EquipmentFilter()).As<IEquipmentFilter>();
            builder.Register(c => new ExercisesFilter()).As<IExercisesFilter>();
            builder.Register(c => new MembershipFilter()).As<IMembershipFilter>();
            builder.Register(c => new PlanFilter()).As<IPlanFilter>();
            builder.Register(c => new ScheduleFilter()).As<IPlanFilter>();
            builder.Register(c => new StepFilter()).As<IStepFilter>();
            builder.Register(c => new TrainerFilter()).As<ITrainerFilter>();
        }

        #endregion Methods
    }
}