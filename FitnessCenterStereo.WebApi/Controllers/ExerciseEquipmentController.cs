using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitnessCenterStereo.WebApi.Models;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.WebApi.Infrastracture.Pagination;
using AutoMapper;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessCenterStereo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ExerciseEquipmentController : BaseApiController
    {
        protected IExerciseEquipmentService Service { get; private set; }
        private readonly IMapper mapper;

        public ExerciseEquipmentController(IExerciseEquipmentService service, IMapper mapperInterface) : base()
        {
            Service = service;
            mapper = mapperInterface;
        }

        public PaginatedList<ExerciseEquipmentViewModel> Find(string searchQuerry, int page, int rpp, string sortBy, bool sortAsc)
        {
            Filter filter = new Filter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return mapper.Map<PaginatedList<ExerciseEquipmentViewModel>>(Service.Find(mapper.Map<IFilter>(filter)));
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public ExerciseEquipmentViewModel Get(Guid id)
        {
            return mapper.Map<ExerciseEquipmentViewModel>(Service.Get(id));
        }

        // POST api/<controller>
        [HttpPost]
        public ExerciseEquipmentViewModel Post([FromBody]ExerciseEquipmentViewModel value)
        {
            return mapper.Map<ExerciseEquipmentViewModel>(Service.Create(mapper.Map<IExerciseEquipment>(value)));
        }

        // PUT api/<controller>/<id>
        [HttpPut]
        public bool Put(ExerciseEquipmentViewModel value)
        {
            return Service.Update(mapper.Map<IExerciseEquipment>(value));

        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }
    }
}
