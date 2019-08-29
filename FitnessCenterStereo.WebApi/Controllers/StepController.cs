﻿using AutoMapper;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.WebApi.Infrastracture.Pagination;
using FitnessCenterStereo.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessCenterStereo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class StepController : BaseApiController
    {
        #region Fields

        private readonly IMapper Mapper;

        #endregion Fields

        #region Constructors

        public StepController(IStepService service, IMapper mapper)
        {
            Mapper = mapper;
            Service = service;
        }

        #endregion Constructors

        #region Properties

        protected IStepService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }

        [HttpGet]
        public PaginatedList<StepViewModel> Find(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            Filter filter = new Filter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return Mapper.Map<PaginatedList<StepViewModel>>(Service.Find(Mapper.Map<IFilter>(filter)));
        }

        // GET: api/<controller>
        [HttpGet("{id}")]
        public StepViewModel Get(Guid id)
        {
            return Mapper.Map<StepViewModel>(Service.Get(id));
        }

        // GET api/<controller>/<id>

        // POST api/<controller>
        [HttpPost]
        public StepViewModel Post([FromBody]StepViewModel step)
        {
            return Mapper.Map<StepViewModel>(Service.Create(Mapper.Map<IStep>(step)));
        }

        // PUT api/<controller>/<id>
        [HttpPut]
        public bool Put(StepViewModel step)
        {
            return Service.Update(Mapper.Map<IStep>(step));
        }

        #endregion Methods
    }
}