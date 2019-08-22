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
    public class ExerciseScheduleController : BaseApiController
    {
        List<ExerciseScheduleViewModel> exerciseSchedules = new List<ExerciseScheduleViewModel>();

        public IEnumerable<ExerciseScheduleViewModel> Find(IFilter filter)
        {
            return exerciseSchedules;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<ExerciseScheduleViewModel> Get()
        {
            return exerciseSchedules;
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public ExerciseScheduleViewModel Get(Guid id)
        {
            return exerciseSchedules.Find(e => e.Id == id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]ExerciseScheduleViewModel value)
        {
            exerciseSchedules.Add(value);
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]ExerciseScheduleViewModel value)
        {
            exerciseSchedules.Where(e => e.Id == id).Select(n => n = value).ToList();
        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            exerciseSchedules.Remove(exerciseSchedules.Find(e => e.Id == id));
        }
    }
}
