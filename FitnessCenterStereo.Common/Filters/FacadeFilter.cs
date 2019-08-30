namespace FitnessCenterStereo.Common.Filters
{
    public class FacadeFilter
    {
        #region Fields

        private readonly IAggregateService myAggregateService;

        #endregion Fields

        #region Constructors

        public FacadeFilter(IAggregateService aggregateService)
        {
            myAggregateService = aggregateService;
        }

        #endregion Constructors
    }
}