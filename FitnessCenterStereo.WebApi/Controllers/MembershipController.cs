using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FitnessCenterStereo.WebApi.Models;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.WebApi.Infrastracture.Pagination;
using FitnessCenterStereo.Service.Common;
using AutoMapper;
using FitnessCenterStereo.Model.Common;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessCenterStereo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class MembershipController : BaseApiController
    {

        protected IMembershipService Service { get; private set; }
        private readonly IMapper mapper;

        public MembershipController(IMembershipService service, IMapper mapperInterface) : base()
        {
            Service = service;
            mapper = mapperInterface;
        }

        public PaginatedList<MembershipViewModel> Find(string searchQuerry, int page, int rpp, string sortBy, bool sortAsc)
        {
            Filter filter = new Filter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return mapper.Map<PaginatedList<MembershipViewModel>>(Service.Find(mapper.Map<IFilter>(filter)));
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

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }
    }
}
