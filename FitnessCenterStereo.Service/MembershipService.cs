using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Model.Common.Infrastracture.Pagination;
using FitnessCenterStereo.Repository.Common;
using FitnessCenterStereo.Service.Common;
using System;

namespace FitnessCenterStereo.Service
{
    internal class MembershipService : IMembershipService
    {
        #region Constructors

        public MembershipService(IMembershipRepository membershipRepository)
        {
            MembershipRepository = membershipRepository;
        }

        #endregion Constructors

        #region Properties

        protected IMembershipRepository MembershipRepository { get; private set; }

        #endregion Properties

        #region Methods

        public IMembership Create(IMembership membership)
        {
            return MembershipRepository.Create(membership);
        }

        public bool Delete(Guid id)
        {
            return MembershipRepository.Delete(id);
        }

        public PaginatedList<IMembership> Find(IMembershipFilter filter)
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

        #endregion Methods
    }
}