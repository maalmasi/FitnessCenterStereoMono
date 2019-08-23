using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCenterStereo.Service;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.WebApi.Models;
using FitnessCenterStereo.Service.Common;
using Microsoft.AspNetCore.Mvc;
using FitnessCenterStereo.DAL.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessCenterStereo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class BodyPartTypeController : BaseApiController
    {
        protected IBodyPartTypeService Service { get; private set; }



        public BodyPartTypeController(IBodyPartTypeService service) : base()
        {
            Service = service;
        }


        public IEnumerable<BodyPartTypeViewModel> Find(IFilter filter)
        {
            return new List<BodyPartTypeViewModel>();
        }


        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public BodyPartTypeViewModel Get(Guid id)
        {
            return new BodyPartTypeViewModel();
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]BodyPartTypeViewModel value)
        {
            
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]BodyPartTypeViewModel value)
        {
            
        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            
        }       
    }
}
