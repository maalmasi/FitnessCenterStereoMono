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
    public class PlanTrainerController : BaseApiController
    {
        #region Fields

        private readonly IMapper mapper;

        #endregion Fields

        #region Constructors

        public PlanTrainerController(IPlanTrainerService service, IMapper mapperInterface) : base()
        {
            Service = service;
            mapper = mapperInterface;
        }

        #endregion Constructors

        #region Properties

        protected IPlanTrainerService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }

        public PaginatedList<PlanTrainerViewModel> Find(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            Filter filter = new Filter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return mapper.Map<PaginatedList<PlanTrainerViewModel>>(Service.Find(mapper.Map<IFilter>(filter)));
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public PlanTrainerViewModel Get(Guid id)
        {
            return mapper.Map<PlanTrainerViewModel>(Service.Get(id));
        }

        // POST api/<controller>
        [HttpPost]
        public PlanTrainerViewModel Post([FromBody]PlanTrainerViewModel value)
        {
            return mapper.Map<PlanTrainerViewModel>(Service.Create(mapper.Map<IPlanTrainer>(value)));
        }

        // PUT api/<controller>/<id>
        [HttpPut]
        public bool Put(PlanTrainerViewModel value)
        {
            return Service.Update(mapper.Map<IPlanTrainer>(value));
        }

        #endregion Methods
    }
}