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
    public class ExerciseEquipmentController : BaseApiController
    {
        List<ExerciseEquipmentViewModel> exerciseEquipments = new List<ExerciseEquipmentViewModel>();

        public IEnumerable<ExerciseEquipmentViewModel> Find(IFilter filter)
        {
            return exerciseEquipments;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<ExerciseEquipmentViewModel> Get()
        {
            return exerciseEquipments;
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public ExerciseEquipmentViewModel Get(Guid id)
        {
            return exerciseEquipments.Find(e => e.Id == id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]ExerciseEquipmentViewModel value)
        {
            exerciseEquipments.Add(value);
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]ExerciseEquipmentViewModel value)
        {
            exerciseEquipments.Where(e => e.Id == id).Select(n => n = value).ToList();
        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            exerciseEquipments.Remove(exerciseEquipments.Find(e => e.Id == id));
        }
    }
}
