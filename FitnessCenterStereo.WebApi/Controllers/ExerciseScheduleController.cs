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
    public class ExerciseScheduleController : BaseApiController
    {
        #region Fields

        private readonly IMapper mapper;

        #endregion Fields

        #region Constructors

        public ExerciseScheduleController(IExerciseScheduleService service, IMapper mapper)
        {
            Service = service;
            this.mapper = mapper;
        }

        #endregion Constructors

        #region Properties

        protected IExerciseScheduleService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
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

        #endregion Methods
    }
}