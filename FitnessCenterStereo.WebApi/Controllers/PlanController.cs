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
    public class PlanController : BaseApiController
    {
        #region Fields

        private readonly IMapper mapper;

        #endregion Fields

        #region Constructors

        public PlanController(IPlanService service, IMapper mapperInterface) : base()
        {
            Service = service;
            mapper = mapperInterface;
        }

        #endregion Constructors

        #region Properties

        protected IPlanService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }

        public PaginatedList<PlanViewModel> Find(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            IPlanFilter filter = new PlanFilter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return mapper.Map<PaginatedList<PlanViewModel>>(Service.Find(mapper.Map<IPlanFilter>(filter)));
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

        #endregion Methods
    }
}