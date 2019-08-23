using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;

namespace FitnessCenterStereo.Service
{
    class DietTypeService : IDietTypeService
    {
        public DietTypeService(IDietTypeRepository dietTypeRepository)
        {
            DietTypeRepository = dietTypeRepository;
        }

        protected IDietTypeRepository DietTypeRepository { get; private set; }

        public IDietType Create(IDietType dietType)
        {
            return DietTypeRepository.Create(dietType);
        }

        public bool Delete(Guid id)
        {
            if (DietTypeRepository.Delete(id))
                return true;
            else return false;
        }

        public IEnumerable<IDietType> Find(IFilter filter)
        {
            return DietTypeRepository.Find(filter);
        }

        public IDietType Get(Guid id)
        {
            return DietTypeRepository.Get(id);
        }

        public bool Update(IDietType dietType)
        {
            if (DietTypeRepository.Update(dietType))
                return true;
            else return false;
        }
    }

}
