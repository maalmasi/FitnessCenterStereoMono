using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitnessCenterStereo.WebApi.Models;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using AutoMapper;
using FitnessCenterStereo.WebApi.Infrastracture.Pagination;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessCenterStereo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class DietTypeController : BaseApiController
    {
        protected IDietTypeService Service { get; private set; }
        private readonly IMapper mapper;

        public DietTypeController(IDietTypeService service, IMapper mapperInterface) : base()
        {
            Service = service;
            mapper = mapperInterface;
        }

        public PaginatedList<DietTypeViewModel> Find(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            Filter filter = new Filter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return mapper.Map<PaginatedList<DietTypeViewModel>>(Service.Find(mapper.Map<IFilter>(filter)));
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

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }
    }
}
