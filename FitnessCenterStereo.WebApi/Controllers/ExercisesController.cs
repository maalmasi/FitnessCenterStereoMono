using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitnessCenterStereo.WebApi.Models;
using FitnessCenterStereo.Common;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessCenterStereo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ExercisesController : BaseApiController
    {
        List<ExercisesViewModel> exercises = new List<ExercisesViewModel>();


        public IEnumerable<ExercisesViewModel> Find(IFilter filter)
        {
            return exercises;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<ExercisesViewModel> Get()
        {
            return exercises;
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public ExercisesViewModel Get(Guid id)
        {
            return exercises.Find(e => e.Id == id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]ExercisesViewModel value)
        {
            exercises.Add(value);
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]ExercisesViewModel value)
        {
            exercises.Where(e => e.Id == id).Select(n => n = value).ToList();
        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            exercises.Remove(exercises.Find(e => e.Id == id));
        }
    }
}
