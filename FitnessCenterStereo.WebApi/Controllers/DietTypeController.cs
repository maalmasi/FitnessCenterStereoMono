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
    public class DietTypeController : BaseApiController
    {
        List<DietTypeViewModel> dietTypes = new List<DietTypeViewModel>();

        public IEnumerable<DietTypeViewModel> Find(IFilter filter)
        {
            return dietTypes;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<DietTypeViewModel> Get()
        {
            return dietTypes;
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public DietTypeViewModel Get(Guid id)
        {
            return dietTypes.Find(e => e.Id == id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]DietTypeViewModel value)
        {
            dietTypes.Add(value);
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]DietTypeViewModel value)
        {
            dietTypes.Where(e => e.Id == id).Select(n => n = value).ToList();
        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            dietTypes.Remove(dietTypes.Find(e => e.Id == id));
        }
    }
}
