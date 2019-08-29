using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Model.Common;

namespace FitnessCenterStereo.Repository.Common
{
    public interface ITrainerRepository : IRepository<ITrainer, Trainer, ITrainerFilter>
    {
    }
}