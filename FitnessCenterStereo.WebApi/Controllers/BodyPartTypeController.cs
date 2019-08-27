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
    public class BodyPartTypeController : BaseApiController
    {
        protected IBodyPartTypeService Service { get; private set; }
        private readonly IMapper mapper;



        public BodyPartTypeController(IBodyPartTypeService service, IMapper mapperInterface) : base()
        {
            Service = service;
            mapper = mapperInterface;
        }

        [HttpGet]
        public PaginatedList<BodyPartTypeViewModel> Find(string searchQuerry, int page = 1, int rpp = 10, string sortBy = "name", bool sortAsc = true)
        {
            Filter filter = new Filter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return mapper.Map<PaginatedList<BodyPartTypeViewModel>>(Service.Find(mapper.Map<IFilter>(filter)));
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
            return mapper.Map<BaseViewModel>(Service.Create(mapper.Map<IBodyPartType>(value)));
        }

        // PUT api/<controller>/<id>
        [HttpPut]
        public bool Put(BaseViewModel value)
        {
            return Service.Update(mapper.Map<IBodyPartType>(value));

        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            Service.Delete(id);
        }
    }
}
