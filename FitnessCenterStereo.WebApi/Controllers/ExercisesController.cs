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
    public class ExercisesController : BaseApiController
    {
        #region Fields

        private readonly IMapper Mapper;

        #endregion Fields

        #region Constructors

        public ExercisesController(IExercisesService service, IMapper mapper)
        {
            Mapper = mapper;
            Service = service;
        }

        #endregion Constructors

        #region Properties

        protected IExercisesService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }

        [HttpGet]
        public PaginatedList<ExercisesViewModel> Find(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            IExercisesFilter filter = new ExercisesFilter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return Mapper.Map<PaginatedList<ExercisesViewModel>>(Service.Find(Mapper.Map<IExercisesFilter>(filter)));
        }

        // GET: api/<controller>
        [HttpGet("{id}")]
        public ExercisesViewModel Get(Guid id)
        {
            return Mapper.Map<ExercisesViewModel>(Service.Get(id));
        }

        // GET api/<controller>/<id>

        // POST api/<controller>
        [HttpPost]
        public ExercisesViewModel Post([FromBody]ExercisesViewModel exercises)
        {
            return Mapper.Map<ExercisesViewModel>(Service.Create(Mapper.Map<IExercises>(exercises)));
        }

        // PUT api/<controller>/<id>
        [HttpPut]
        public bool Put(ExercisesViewModel exercises)
        {
            return Service.Update(Mapper.Map<IExercises>(exercises));
        }

        #endregion Methods
    }
}