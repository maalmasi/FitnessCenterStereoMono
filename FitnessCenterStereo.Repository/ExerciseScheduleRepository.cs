using AutoMapper;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.DAL.Data;
using FitnessCenterStereo.DAL.Models;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Repository
{
    class ExerciseScheduleRepository : IExerciseScheduleRepository
    {
        protected ApplicationDbContext appDbContext { get; private set; }
        private readonly IMapper mapper;
        public ExerciseScheduleRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            appDbContext = dbContext;
            this.mapper = mapper;
        }
        public IExerciseSchedule Create(IExerciseSchedule exerciseSchedule)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {

            ExerciseSchedule ToDelete = appDbContext.ExerciseSchedule.Find(id);
            if (ToDelete != null) { appDbContext.ExerciseSchedule.Remove(ToDelete); return true; }

            return false;

        }

        public IEnumerable<IExerciseSchedule> Find(IFilter filter)
        {
            return (IEnumerable<IExerciseSchedule>)appDbContext.ExerciseSchedule.Find(filter);

        }

        public IExerciseSchedule Get(Guid id)
        {
            return mapper.Map<IExerciseSchedule>(appDbContext.ExerciseSchedule.Find(id));
        }

        public bool Update(IExerciseSchedule exerciseSchedule)
        {
            ExerciseSchedule ToUpdate = appDbContext.ExerciseSchedule.Find(exerciseSchedule);
            appDbContext.ExerciseSchedule.Update(ToUpdate);
            if (ToUpdate != exerciseSchedule) { return true; }

            return false;
        }
    }
}
