using System;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.WebApi.Models;
using FitnessCenterStereo.Service.Common;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using FitnessCenterStereo.WebApi.Infrastracture.Pagination;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessCenterStereo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ComplexityLevelTypeController : BaseApiController
    {
        protected IComplexityLevelTypeService Service { get; private set; }
        private readonly IMapper mapper;


        public ComplexityLevelTypeController(IComplexityLevelTypeService service, IMapper mapper) : base()
        {
            Service = service;
            this.mapper = mapper;
        }

        // GET: api/<controller>

        [HttpGet]
        public PaginatedList<ComplexityLevelTypeViewModel> Find(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            Filter filter = new Filter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return mapper.Map<PaginatedList<ComplexityLevelTypeViewModel>>(Service.Find(mapper.Map<IFilter>(filter)));
        }
        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public BaseViewModel Get(Guid id)
        {
            return mapper.Map<BaseViewModel>(Service.Get(id));
        }

        // POST api/<controller>
        [HttpPost]
        public BaseViewModel Post([FromBody]BaseViewModel value)
        {
            return mapper.Map<BaseViewModel>(Service.Create(mapper.Map<IComplexityLevelType>(value)));
        }


        // PUT api/<controller>/<id>
        [HttpPut]
        public bool Put(BaseViewModel value)
        {
            return Service.Update(mapper.Map<IComplexityLevelType>(value));
           
        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }
    }
}

