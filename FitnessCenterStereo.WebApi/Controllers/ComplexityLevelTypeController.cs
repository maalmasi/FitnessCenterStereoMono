using AutoMapper;
using FitnessCenterStereo.Common;
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
    public class ComplexityLevelTypeController : BaseApiController
    {
        #region Fields

        private readonly IMapper mapper;

        #endregion Fields

        #region Constructors

        public ComplexityLevelTypeController(IComplexityLevelTypeService service, IMapper mapper) : base()
        {
            Service = service;
            this.mapper = mapper;
        }

        #endregion Constructors

        #region Properties

        protected IComplexityLevelTypeService Service { get; private set; }

        #endregion Properties

        // GET: api/<controller>

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }

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

        #endregion Methods
    }
}