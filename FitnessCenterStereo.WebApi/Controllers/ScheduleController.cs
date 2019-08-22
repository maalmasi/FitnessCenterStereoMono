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
    public class ScheduleController : BaseApiController
    {
        List<ScheduleViewModel> schedules = new List<ScheduleViewModel>();

        public IEnumerable<ScheduleViewModel> Find(IFilter filter)
        {
            return schedules;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<ScheduleViewModel> Get()
        {
            return schedules;
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public ScheduleViewModel Get(Guid id)
        {
            return schedules.Find(e => e.Id == id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]ScheduleViewModel value)
        {
            schedules.Add(value);
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]ScheduleViewModel value)
        {
            schedules.Where(e => e.Id == id).Select(n => n = value).ToList();
        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            schedules.Remove(schedules.Find(e => e.Id == id));
        }
    }
}

