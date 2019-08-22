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
    public class ComplexityLevelTypeController : BaseApiController
    {
        List<ComplexityLevelTypeViewModel> complexityLevelTypes = new List<ComplexityLevelTypeViewModel>();


        public IEnumerable<ComplexityLevelTypeViewModel> Find(IFilter filter)
        {
            return complexityLevelTypes;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<ComplexityLevelTypeViewModel> Get()
        {
            return complexityLevelTypes;
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public ComplexityLevelTypeViewModel Get(Guid id)
        {
            return complexityLevelTypes.Find(e => e.Id == id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]ComplexityLevelTypeViewModel value)
        {
            complexityLevelTypes.Add(value);
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]ComplexityLevelTypeViewModel value)
        {
            complexityLevelTypes.Where(e => e.Id == id).Select(n => n = value).ToList();
        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            complexityLevelTypes.Remove(complexityLevelTypes.Find(e => e.Id == id));
        }
    }

}
