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


        public IEnumerable<BodyPartTypeViewModel> Find(IFilter filter)
        {
            return new List<BodyPartTypeViewModel>();
        }


        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public BodyPartTypeViewModel Get(Guid id)
        {
            Service.Get(id);
            //BodyPartTypeViewModel model = new BodyPartTypeViewModel();
            //model.Id = Service.Get(id).Id;
            //model.Name = Service.Get(id).Name;
            //model.Abbreviation = Service.Get(id).Abbreviation;
            //model.DateCreated = Service.Get(id).DateCreated;
            //model.DateUpdated = Service.Get(id).DateUpdated;

            return mapper.Map < BodyPartTypeViewModel > (Service.Get(id));
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
            Service.Delete(id);
        }       
    }
}
