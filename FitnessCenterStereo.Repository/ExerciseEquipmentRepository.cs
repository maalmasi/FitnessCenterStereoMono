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
    class ExerciseEquipmentRepository : IExerciseEquipmentRepository
    {
        protected ApplicationDbContext appDbContext { get; private set; }
        private readonly IMapper mapper;
        public ExerciseEquipmentRepository (ApplicationDbContext dbContext,IMapper mapper)
        {
            appDbContext = dbContext;
            this.mapper = mapper;
        }

        public bool Delete(Guid id)
        {
            ExerciseEquipment ToDelete = appDbContext.ExerciseEquipment.Find(id);
            if (ToDelete != null) { appDbContext.ExerciseEquipment.Remove(ToDelete); return true; }

            return false;
        }

        public IEnumerable<IExerciseEquipment> Find(IFilter filter)
        {
            return (IEnumerable<IExerciseEquipment>)appDbContext.ExerciseEquipment.Find(filter);
        }

        public IExerciseEquipment Get(Guid id)
        {
            return mapper.Map<IExerciseEquipment>(appDbContext.ExerciseEquipment.Find(id));
        }

        public bool Update(IExerciseEquipment exerciseEquipment)
        {
            ExerciseEquipment ToUpdate = appDbContext.ExerciseEquipment.Find(exerciseEquipment);
            appDbContext.ExerciseEquipment.Update(ToUpdate);
            if (ToUpdate != exerciseEquipment) { return true; }

            return false;
        }

        public IExerciseEquipment Create(IExerciseEquipment exerciseEquipment)
        {
            throw new NotImplementedException();
        }
    }
}
