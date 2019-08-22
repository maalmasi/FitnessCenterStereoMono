using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessCenterStereo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TrainerController : BaseApiController
    {
        List<TrainerViewModel> trainers = new List<TrainerViewModel>();

        public IEnumerable<TrainerViewModel> Find(IFilter filter)
        {
            return trainers;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<TrainerViewModel> Get()
        {
            return trainers;
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public TrainerViewModel Get(Guid id)
        {
            return trainers.Find(e => e.Id == id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]TrainerViewModel value)
        {
            trainers.Add(value);
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]TrainerViewModel value)
        {
            trainers.Where(e => e.Id == id).Select(n => n = value).ToList();
        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            trainers.Remove(trainers.Find(e => e.Id == id));
        }
    }
}
