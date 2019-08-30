namespace FitnessCenterStereo.Common.Filters
{
    public interface IAggregateService
    {
        #region Properties

        IBodyPartTypeFilter BodyPartTypeFilter { get; }
        ICardFilter CardFilter { get; }
        IComplexityLevelTypeFilter ComplexityLevelTypeFilter { get; }
        IDietTypeFilter DietTypeFilter { get; }
        IEquipmentFilter EquipmentFilter { get; }
        IExercisesFilter ExercisesFilter { get; }
        IMembershipFilter MembershipFilter { get; }
        IPlanFilter PlanFilter { get; }
        IScheduleFilter ScheduleFilter { get; }
        IStepFilter StepFilter { get; }
        ITrainerFilter TrainerFilter { get; }

        #endregion Properties
    }
}