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
    public class EquipmentController : BaseApiController
    {
        List<EquipmentViewModel> equipments = new List<EquipmentViewModel>();


        public IEnumerable<EquipmentViewModel> Find(IFilter filter)
        {
            return equipments;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<EquipmentViewModel> Get()
        {
            return equipments;
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public EquipmentViewModel Get(Guid id)
        {
            return equipments.Find(e => e.Id == id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]EquipmentViewModel value)
        {
            equipments.Add(value);
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]EquipmentViewModel value)
        {
            equipments.Where(e => e.Id == id).Select(n => n = value).ToList();
        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            equipments.Remove(equipments.Find(e => e.Id == id));
        }
    }
}
