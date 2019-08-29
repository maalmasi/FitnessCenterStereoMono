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
    public class TrainerController : BaseApiController
    {
        #region Fields

        private readonly IMapper Mapper;

        #endregion Fields

        #region Constructors

        public TrainerController(ITrainerService service, IMapper mapper)
        {
            Mapper = mapper;
            Service = service;
        }

        #endregion Constructors

        #region Properties

        protected ITrainerService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }

        [HttpGet]
        public PaginatedList<TrainerViewModel> Find(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            Filter filter = new Filter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return Mapper.Map<PaginatedList<TrainerViewModel>>(Service.Find(Mapper.Map<IFilter>(filter)));
        }

        // GET: api/<controller>
        [HttpGet("{id}")]
        public TrainerViewModel Get(Guid id)
        {
            return Mapper.Map<TrainerViewModel>(Service.Get(id));
        }

        // GET api/<controller>/<id>

        // POST api/<controller>
        [HttpPost]
        public TrainerViewModel Post([FromBody]TrainerViewModel trainer)
        {
            return Mapper.Map<TrainerViewModel>(Service.Create(Mapper.Map<ITrainer>(trainer)));
        }

        // PUT api/<controller>/<id>
        [HttpPut]
        public bool Put(TrainerViewModel trainer)
        {
            return Service.Update(Mapper.Map<ITrainer>(trainer));
        }

        #endregion Methods
    }
}