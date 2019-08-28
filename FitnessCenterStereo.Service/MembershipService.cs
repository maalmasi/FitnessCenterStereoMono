using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;

namespace FitnessCenterStereo.Service
{
    class MembershipService : IMembershipService
    {
        public MembershipService(IMembershipRepository membershipRepository)
        {
            MembershipRepository = membershipRepository;
        }

        protected IMembershipRepository MembershipRepository { get; private set; }

        public IMembership Create(IMembership membership)
        {
            return MembershipRepository.Create(membership);
        }

        public bool Delete(Guid id)
        {
            return MembershipRepository.Delete(id);
        }

        public PaginatedList<IMembership> Find(IFilter filter)
        {
            return MembershipRepository.Find(filter);
        }

        public IMembership Get(Guid id)
        {
            return MembershipRepository.Get(id);
        }

        public bool Update(IMembership membership)
        {
            return MembershipRepository.Update(membership);
        }

    }

}
