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
    public class EquipmentController : BaseApiController
    {
        #region Fields

        private readonly IMapper mapper;

        #endregion Fields

        #region Constructors

        public EquipmentController(IEquipmentService service, IMapper mapperInterface) : base()
        {
            Service = service;
            mapper = mapperInterface;
        }

        #endregion Constructors

        #region Properties

        protected IEquipmentService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }

        public PaginatedList<EquipmentViewModel> Find(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            IEquipmentFilter filter = new EquipmentFilter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return mapper.Map<PaginatedList<EquipmentViewModel>>(Service.Find(mapper.Map<IEquipmentFilter>(filter)));
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

        #endregion Methods
    }
}