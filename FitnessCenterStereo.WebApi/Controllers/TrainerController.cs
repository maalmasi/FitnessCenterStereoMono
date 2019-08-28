using System;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.WebApi.Models;
using FitnessCenterStereo.Service.Common;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using FitnessCenterStereo.WebApi.Infrastracture.Pagination;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessCenterStereo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TrainerController : BaseApiController
    {
        protected ITrainerService Service { get; private set; }
        private readonly IMapper Mapper;

        public TrainerController(ITrainerService service, IMapper mapper) {
            Mapper = mapper;
            Service = service;
        }
        [HttpGet]
        public PaginatedList<TrainerViewModel> Find(string searchQuerry, int page = 1, int rpp = 10, string sortBy = "firstname", bool sortAsc = true)
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

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }
    }
}
