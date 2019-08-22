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
    public class StepController : BaseApiController
    {
        List<StepViewModel> steps = new List<StepViewModel>();

        public IEnumerable<StepViewModel> Find(IFilter filter)
        {
            return steps;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<StepViewModel> Get()
        {
            return steps;
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public StepViewModel Get(Guid id)
        {
            return steps.Find(e => e.Id == id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]StepViewModel value)
        {
            steps.Add(value);
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]StepViewModel value)
        {
            steps.Where(e => e.Id == id).Select(n => n = value).ToList();
        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            steps.Remove(steps.Find(e => e.Id == id));
        }
    }
}
