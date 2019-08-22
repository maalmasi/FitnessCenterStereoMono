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
        List<BodyPartTypeViewModel> bodyPartTypes = new List<BodyPartTypeViewModel>();
        ApplicationDbContext apcont;
            public BodyPartTypeController(ApplicationDbContext appDbContext)
        {
            apcont = appDbContext;
        }


        public IEnumerable<BodyPartTypeViewModel> Find(IFilter filter)
        {
            return bodyPartTypes;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<BodyPartTypeViewModel> Get()
        {
            return bodyPartTypes;
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public BodyPartTypeViewModel Get(Guid id)
        {
            //return bodyPartTypes.Find(e=>e.Id == id);
            IBodyPartTypeService BodyPart = new BodyPartTypeService();
            return (BodyPartTypeViewModel)BodyPart.Get(Guid.Parse("cde1883f-9bfb-421a-8f31-9d00a0086498"));
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]BodyPartTypeViewModel value)
        {
            bodyPartTypes.Add(value);
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]BodyPartTypeViewModel value)
        {
            bodyPartTypes.Where(e => e.Id == id).Select(n => n = value).ToList();
        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            bodyPartTypes.Remove(bodyPartTypes.Find(e=>e.Id == id));
        }       
    }
}
