using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.DAL.Data;
using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.DAL.Models;
using AutoMapper;

namespace FitnessCenterStereo.Repository
{
    class EquipmentRepository : IEquipmentRepository
    {
        protected ApplicationDbContext appDbContext { get; private set; }
        private readonly IMapper mapper;

        public EquipmentRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            appDbContext = dbContext;
            this.mapper = mapper;

        }
        public IEquipment Create(IEquipment equipment)
        {
            return mapper.Map<IEquipment>(appDbContext.Equipment.Add(mapper.Map<Equipment>(equipment)));
        }


            public bool Delete(Guid id)
        {
            Equipment ToDelete = appDbContext.Equipment.Find(id);
            if (ToDelete != null) { appDbContext.Equipment.Remove(ToDelete); return true; }

            return false;

        }

        public IEnumerable<IEquipment> Find(IFilter filter)
        {
            return (IEnumerable<IEquipment>)appDbContext.Equipment.Find(filter);

        }

        public IEquipment Get(Guid id)
        {
            return mapper.Map<IEquipment>(appDbContext.Equipment.Find(id));
        }

        public bool Update(IEquipment equipment)
        {
            Equipment ToUpdate = appDbContext.Equipment.Find(equipment);
            appDbContext.Equipment.Update(ToUpdate);
            if (ToUpdate != equipment) { return true; }

            return false;
        }
    }
}
