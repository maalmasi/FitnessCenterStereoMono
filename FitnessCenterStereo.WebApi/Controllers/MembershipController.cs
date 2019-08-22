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
    public class MembershipController : BaseApiController
    {
        List<MembershipViewModel> memberships = new List<MembershipViewModel>();

        public IEnumerable<MembershipViewModel> Find(IFilter filter)
        {
            return memberships;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<MembershipViewModel> Get()
        {
            return memberships;
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public MembershipViewModel Get(Guid id)
        {
            return memberships.Find(e => e.Id == id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]MembershipViewModel value)
        {
            memberships.Add(value);
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]MembershipViewModel value)
        {
            memberships.Where(e => e.Id == id).Select(n => n = value).ToList();
        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            memberships.Remove(memberships.Find(e => e.Id == id));
        }
    }
}
