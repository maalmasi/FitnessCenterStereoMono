using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class ScheduleController : BaseApiController
    {
        protected IScheduleService Service { get; private set; }
        private readonly IMapper mapper;

        public ScheduleController(IScheduleService service, IMapper mapper)
        {
            Service = service;
            this.mapper = mapper;
        }

        [HttpGet]
        public PaginatedList<ScheduleViewModel> Find(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            Filter filter = new Filter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
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

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }
    }
}

