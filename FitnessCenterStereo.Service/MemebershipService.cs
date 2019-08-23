using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;

namespace FitnessCenterStereo.Service
{
    class MemebershipService
    {
        public MemebershipService(IBodyPartTypeRepository membershipRepository)
        {
            MembershipRepository = membershipRepository;
        }

        protected IBodyPartTypeRepository MembershipRepository { get; private set; }

        public IBodyPartType Create(IBodyPartType membership)
        {
            return MembershipRepository.Create(membership);
        }

        public bool Delete(Guid id)
        {
            if (MembershipRepository.Delete(id))
                return true;
            else return false;
        }

        public IEnumerable<IBodyPartType> Find(IFilter filter)
        {
            return MembershipRepository.Find(filter);
        }

        public IBodyPartType Get(Guid id)
        {
            return MembershipRepository.Get(id);
        }

        public bool Update(IBodyPartType membership)
        {
            if (MembershipRepository.Update(membership))
                return true;
            else return false;
        }

    }

}
