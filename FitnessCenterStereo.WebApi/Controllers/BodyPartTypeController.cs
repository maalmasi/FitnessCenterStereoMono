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
using AutoMapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessCenterStereo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class BodyPartTypeController : BaseApiController
    {
        protected IBodyPartTypeService Service { get; private set; }
        private readonly IMapper mapper;



        public BodyPartTypeController(IBodyPartTypeService service, IMapper mapperInterface) : base()
        {
            Service = service;
            mapper = mapperInterface;
        }

        [HttpGet]
        public IEnumerable<BodyPartTypeViewModel> Find([FromBody]Filter filter)
        {
            return mapper.Map<IEnumerable<BodyPartTypeViewModel>>(Service.Find(mapper.Map<IFilter>(filter)));
        }


        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public BodyPartTypeViewModel Get(Guid id)
        {
            return mapper.Map < BodyPartTypeViewModel > (Service.Get(id));
        }

        // POST api/<controller>
        [HttpPost]
        public BodyPartTypeViewModel Post([FromBody]BodyPartTypeViewModel value)
        {
            return mapper.Map<BodyPartTypeViewModel>(Service.Create(mapper.Map<IBodyPartType>(value)));
        }

        // PUT api/<controller>/<id>
        [HttpPut]
        public bool Put(BodyPartTypeViewModel value)
        {
            Service.Update(mapper.Map<IBodyPartType>(value));
            return true; 
        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            Service.Delete(id);
        }       
    }
}
