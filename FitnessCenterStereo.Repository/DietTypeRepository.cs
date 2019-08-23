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
    class DietTypeRepository : IDietTypeRepository
    {
        protected ApplicationDbContext appDbContext { get; private set; }
        public DietTypeRepository(ApplicationDbContext applicationDbContext)
        {
            appDbContext = applicationDbContext;

        }
        public IDietType Create(IDietType diet)
        {
            return (IDietType)appDbContext.DietType.Add(new DietType());
        }

        public bool Delete(Guid id)
        {

            DietType ToDelete = appDbContext.DietType.Find(id);
            if (ToDelete != null) { appDbContext.DietType.Remove(ToDelete); return true; }

            return false;
        }

        public IEnumerable<IDietType> Find(IFilter filter)
        {
            return (IEnumerable<IDietType>)appDbContext.DietType.Find(filter);
        }

        public IDietType Get(Guid id)
        {
            IDietType diet = (IDietType)appDbContext.Card.Find(id);
            return diet;
        }

        public bool Update(IDietType dietType)
        {
            DietType ToUpdate = appDbContext.DietType.Find(dietType);
            appDbContext.DietType.Update(ToUpdate);
            if (ToUpdate != dietType) { return true; }

            return false;
        }
    }
}
