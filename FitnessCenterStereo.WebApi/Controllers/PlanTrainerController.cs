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
    public class PlanTrainerController : BaseApiController
    {
        List<PlanTrainerViewModel> planTrainers = new List<PlanTrainerViewModel>();


        public IEnumerable<PlanTrainerViewModel> Find(IFilter filter)
        {
            return planTrainers;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<PlanTrainerViewModel> Get()
        {
            return planTrainers;
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public PlanTrainerViewModel Get(Guid id)
        {
            return planTrainers.Find(e => e.Id == id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]PlanTrainerViewModel value)
        {
            planTrainers.Add(value);
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]PlanTrainerViewModel value)
        {
            planTrainers.Where(e => e.Id == id).Select(n => n = value).ToList();
        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            planTrainers.Remove(planTrainers.Find(e => e.Id == id));
        }
    }
}
