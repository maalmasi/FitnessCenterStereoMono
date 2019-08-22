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
    public class CardController : BaseApiController
    {
        List<CardViewModel> cards = new List<CardViewModel>();


        public IEnumerable<CardViewModel> Find(IFilter filter)
        {
            return cards;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<CardViewModel> Get()
        {
            return cards;
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public CardViewModel Get(Guid id)
        {
            return cards.Find(e => e.Id == id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]CardViewModel value)
        {
            cards.Add(value);
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]CardViewModel value)
        {
            cards.Where(e => e.Id == id).Select(n => n = value).ToList();
        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            cards.Remove(cards.Find(e => e.Id == id));
        }
    }
    
}
