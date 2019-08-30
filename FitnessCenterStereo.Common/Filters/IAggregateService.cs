namespace FitnessCenterStereo.Common.Filters
{
    public interface IAggregateService
    {
        #region Properties

        IBodyPartTypeFilter bodyPartTypeFilter { get; }
        ICardFilter cardFilter { get; }
        IComplexityLevelTypeFilter complexityLevelTypeFilter { get; }
        IDietTypeFilter dietTypeFilter { get; }
        IEquipmentFilter equipmentFilter { get; }
        IExercisesFilter exercisesFilter { get; }
        IMembershipFilter membershipFilter { get; }
        IPlanFilter planFilter { get; }
        IScheduleFilter scheduleFilter { get; }
        IStepFilter stepFilter { get; }
        ITrainerFilter trainerFilter { get; }

        #endregion Properties
    }
}