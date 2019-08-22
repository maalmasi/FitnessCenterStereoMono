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
    public class PlanController : BaseApiController
    {
        List<PlanViewModel> plans = new List<PlanViewModel>();


        public IEnumerable<PlanViewModel> Find(IFilter filter)
        {
            return plans;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<PlanViewModel> Get()
        {
            return plans;
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public PlanViewModel Get(Guid id)
        {
            return plans.Find(e => e.Id == id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]PlanViewModel value)
        {
            plans.Add(value);
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]PlanViewModel value)
        {
            plans.Where(e => e.Id == id).Select(n => n = value).ToList();
        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            plans.Remove(plans.Find(e => e.Id == id));
        }
    }
}
