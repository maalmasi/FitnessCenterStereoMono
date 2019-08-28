using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitnessCenterStereo.WebApi.Models;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.WebApi.Infrastracture.Pagination;
using AutoMapper;
using FitnessCenterStereo.Model.Common;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessCenterStereo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ExercisesController : BaseApiController
    {


        protected IExercisesService Service { get; private set; }
        private readonly IMapper Mapper;

        public ExercisesController(IExercisesService service, IMapper mapper)
        {
            Mapper = mapper;
            Service = service;
        }
        [HttpGet]
        public PaginatedList<ExercisesViewModel> Find(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            Filter filter = new Filter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return Mapper.Map<PaginatedList<ExercisesViewModel>>(Service.Find(Mapper.Map<IFilter>(filter)));
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

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }

    }
}
