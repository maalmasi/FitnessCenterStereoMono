using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Model.Common;

namespace FitnessCenterStereo.Repository.Common
{
    public interface IStepRepository : IRepository<IStep, Step, IStepFilter>
    {
    }
}