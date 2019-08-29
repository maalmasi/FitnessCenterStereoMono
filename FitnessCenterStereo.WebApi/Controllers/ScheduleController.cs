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
    public class ScheduleController : BaseApiController
    {
        #region Fields

        private readonly IMapper mapper;

        #endregion Fields

        #region Constructors

        public ScheduleController(IScheduleService service, IMapper mapper)
        {
            Service = service;
            this.mapper = mapper;
        }

        #endregion Constructors

        #region Properties

        protected IScheduleService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }

        [HttpGet]
        public PaginatedList<ScheduleViewModel> Find(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            IScheduleFilter filter = new ScheduleFilter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return mapper.Map<PaginatedList<ScheduleViewModel>>(Service.Find(filter));
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public ScheduleViewModel Get(Guid id)
        {
            return mapper.Map<ScheduleViewModel>(Service.Get(id));
        }

        // POST api/<controller>
        [HttpPost]
        public ScheduleViewModel Post([FromBody] ScheduleViewModel value)
        {
            return mapper.Map<ScheduleViewModel>(Service.Create(mapper.Map<ISchedule>(value)));
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public bool Put(ScheduleViewModel value)
        {
            return Service.Update(mapper.Map<ISchedule>(value));
        }

        #endregion Methods
    }
}