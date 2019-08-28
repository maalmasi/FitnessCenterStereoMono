using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitnessCenterStereo.WebApi.Models;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using AutoMapper;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.WebApi.Infrastracture.Pagination;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessCenterStereo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class EquipmentController : BaseApiController
    {
        protected IEquipmentService Service { get; private set; }
        private readonly IMapper mapper;

        public EquipmentController(IEquipmentService service, IMapper mapperInterface) : base()
        {
            Service = service;
            mapper = mapperInterface;
        }

        public PaginatedList<EquipmentViewModel> Find(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            Filter filter = new Filter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return mapper.Map<PaginatedList<EquipmentViewModel>>(Service.Find(mapper.Map<IFilter>(filter)));
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public EquipmentViewModel Get(Guid id)
        {
            return mapper.Map<EquipmentViewModel>(Service.Get(id));
        }

        // POST api/<controller>
        [HttpPost]
        public EquipmentViewModel Post([FromBody]EquipmentViewModel value)
        {
            return mapper.Map<EquipmentViewModel>(Service.Create(mapper.Map<IEquipment>(value)));
        }

        // PUT api/<controller>/<id>
        [HttpPut]
        public bool Put(EquipmentViewModel value)
        {
            return Service.Update(mapper.Map<IEquipment>(value));

        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }
    }
}
