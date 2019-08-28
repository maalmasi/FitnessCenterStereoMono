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
    public class PlanController : BaseApiController
    {

        protected IPlanService Service { get; private set; }
        private readonly IMapper mapper;

        public PlanController(IPlanService service, IMapper mapperInterface) : base()
        {
            Service = service;
            mapper = mapperInterface;
        }

        public PaginatedList<PlanViewModel> Find(string searchQuerry=DefaultSearchQuerry, int page=DefaultPage, int rpp=DefaultRpp, string sortBy=DefaultSortBy, bool sortAsc=DefaultSortAsc)
        {
            Filter filter = new Filter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return mapper.Map<PaginatedList<PlanViewModel>>(Service.Find(mapper.Map<IFilter>(filter)));
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public PlanViewModel Get(Guid id)
        {
            return mapper.Map<PlanViewModel>(Service.Get(id));
        }

        // POST api/<controller>
        [HttpPost]
        public PlanViewModel Post([FromBody]PlanViewModel value)
        {
            return mapper.Map<PlanViewModel>(Service.Create(mapper.Map<IPlan>(value)));
        }

        // PUT api/<controller>/<id>
        [HttpPut]
        public bool Put(PlanViewModel value)
        {
            return Service.Update(mapper.Map<IPlan>(value));

        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }
    }
}
