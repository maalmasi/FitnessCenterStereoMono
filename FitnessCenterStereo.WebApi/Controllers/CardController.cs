﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCenterStereo.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessCenterStereo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class CardController : BaseApiController
    {
        List<CardViewModel> cards = new List<CardViewModel>() {
            new CardViewModel{
                Id=Guid.NewGuid(),DateCreated = DateTime.Now, DateUpdated = DateTime.Now,MembershipId = Guid.NewGuid(),UserId=string.Empty
            }
        };
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<CardViewModel> Get()
        {
            return cards;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}