using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCenterStereo.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessCenterStereo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class BodyPartTypeController : BaseApiController
    {
        List<BodyPartTypeViewModel> bodyPartTypes = new List<BodyPartTypeViewModel>();

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<BodyPartTypeViewModel> Get()
        {
            return bodyPartTypes;
        }

        // GET api/<controller>/<Guid>
        [HttpGet("{Guid}")]
        public BodyPartTypeViewModel Get(Guid id)
        {
            return bodyPartTypes.Find(e=>e.Id == id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]BodyPartTypeViewModel value)
        {
            bodyPartTypes.Add(value);
        }

        // PUT api/<controller>/<Guid>
        [HttpPut("{Guid}")]
        public void Put(Guid id, [FromBody]BodyPartTypeViewModel value)
        {
            bodyPartTypes.Where(e => e.Id == id).Select(n => n = value).ToList();
        }

        // DELETE api/<controller>/<Guid>
        [HttpDelete("{Guid}")]
        public void Delete(Guid id)
        {
            bodyPartTypes.Remove(bodyPartTypes.Find(e=>e.Id == id));
        }
    }
}
