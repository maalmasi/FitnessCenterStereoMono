using AutoMapper;
using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.WebApi.Infrastracture.Pagination;
using FitnessCenterStereo.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessCenterStereo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class MembershipController : BaseApiController
    {
        #region Fields

        private readonly IMapper mapper;

        #endregion Fields

        #region Constructors

        public MembershipController(IMembershipService service, IMapper mapperInterface) : base()
        {
            Service = service;
            mapper = mapperInterface;
        }

        #endregion Constructors

        #region Properties

        protected IMembershipService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }

        public PaginatedList<MembershipViewModel> Find(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            IMembershipFilter filter = new MembershipFilter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return mapper.Map<PaginatedList<MembershipViewModel>>(Service.Find(mapper.Map<IMembershipFilter>(filter)));
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public MembershipViewModel Get(Guid id)
        {
            return mapper.Map<MembershipViewModel>(Service.Get(id));
        }

        // POST api/<controller>
        [HttpPost]
        public MembershipViewModel Post([FromBody]MembershipViewModel value)
        {
            return mapper.Map<MembershipViewModel>(Service.Create(mapper.Map<IMembership>(value)));
        }

        // PUT api/<controller>/<id>
        [HttpPut]
        public bool Put(MembershipViewModel value)
        {
            return Service.Update(mapper.Map<IMembership>(value));
        }

        #endregion Methods
    }
}