﻿using AutoMapper;
using FitnessCenterStereo.Common.Filters;
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
    public class BodyPartTypeController : BaseApiController
    {
        #region Fields

        private readonly IMapper mapper;

        #endregion Fields

        #region Constructors

        public BodyPartTypeController(IBodyPartTypeService service, IMapper mapperInterface) : base()
        {
            Service = service;
            mapper = mapperInterface;
        }

        #endregion Constructors

        #region Properties

        protected IBodyPartTypeService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }

        [HttpGet]
        public PaginatedList<BodyPartTypeViewModel> Find(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            IBodyPartTypeFilter filter = new BodyPartTypeFilter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return mapper.Map<PaginatedList<BodyPartTypeViewModel>>(Service.Find(mapper.Map<IBodyPartTypeFilter>(filter)));
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public BodyPartTypeViewModel Get(Guid id)
        {
            return mapper.Map<BodyPartTypeViewModel>(Service.Get(id));
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
            return Service.Update(mapper.Map<IBodyPartType>(value));
        }

        #endregion Methods
    }
}