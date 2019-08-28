using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitnessCenterStereo.WebApi.Models;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.WebApi.Infrastracture.Pagination;
using FitnessCenterStereo.Service.Common;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessCenterStereo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ExerciseScheduleController : BaseApiController
    {
        protected IExerciseScheduleService Service { get; private set; }
        private readonly IMapper mapper;

        public ExerciseScheduleController(IExerciseScheduleService service, IMapper mapper)
        {
            Service = service;
            this.mapper = mapper;
        }

        [HttpGet]
        public PaginatedList<ExerciseScheduleViewModel> Find(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            Filter filter = new Filter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return mapper.Map<PaginatedList<ExerciseScheduleViewModel>>(Service.Find(filter));
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public ExerciseScheduleViewModel Get(Guid id)
        {
            return mapper.Map<ExerciseScheduleViewModel>(Service.Get(id));
        }

        // POST api/<controller>
        [HttpPost]
        public ExerciseScheduleViewModel Post([FromBody] ExerciseScheduleViewModel value)
        {
            return mapper.Map<ExerciseScheduleViewModel>(Service.Create(mapper.Map<IExerciseSchedule>(value)));
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public bool Put(ExerciseScheduleViewModel value)
        {
            return Service.Update(mapper.Map<IExerciseSchedule>(value));
        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }
    }
}
