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
    public class DietTypeController : BaseApiController
    {
        #region Fields

        private readonly IMapper mapper;

        #endregion Fields

        #region Constructors

        public DietTypeController(IDietTypeService service, IMapper mapperInterface) : base()
        {
            Service = service;
            mapper = mapperInterface;
        }

        #endregion Constructors

        #region Properties

        protected IDietTypeService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }

        public PaginatedList<DietTypeViewModel> Find(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            IDietTypeFilter filter = new DietTypeFilter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return mapper.Map<PaginatedList<DietTypeViewModel>>(Service.Find(mapper.Map<IDietTypeFilter>(filter)));
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public DietTypeViewModel Get(Guid id)
        {
            return mapper.Map<DietTypeViewModel>(Service.Get(id));
        }

        // POST api/<controller>
        [HttpPost]
        public DietTypeViewModel Post([FromBody]DietTypeViewModel value)
        {
            return mapper.Map<DietTypeViewModel>(Service.Create(mapper.Map<IDietType>(value)));
        }

        // PUT api/<controller>/<id>
        [HttpPut]
        public bool Put(MembershipViewModel value)
        {
            return Service.Update(mapper.Map<IDietType>(value));
        }

        #endregion Methods
    }
}