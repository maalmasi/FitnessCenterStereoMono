﻿using AutoMapper;
using FitnessCenterStereo.Common.Filters;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.WebApi.Infrastracture.Pagination;
using FitnessCenterStereo.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessCenterStereo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ComplexityLevelTypeController : BaseApiController
    {
        #region Fields

        private readonly IMapper mapper;

        #endregion Fields

        #region Constructors

        public ComplexityLevelTypeController(IComplexityLevelTypeService service, IMapper mapper, IFacadeFilter filter) : base()
        {
            Service = service;
            this.mapper = mapper;
            Filter = filter;
        }

        #endregion Constructors

        #region Properties

        protected IFacadeFilter Filter { get; private set; }
        protected IComplexityLevelTypeService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public async Task<bool> DeleteAsync(Guid id)
        {
            return await Service.DeleteAsync(id);
        }

        [HttpGet]
        public async Task<PaginatedList<ComplexityLevelTypeViewModel>> FindAsync(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            IComplexityLevelTypeFilter filter = Filter.CreateComplexityLevelTypeFilter();
            filter.SearchQuery = searchQuerry;
            filter.Page = page;
            filter.RecordsPerPage = rpp;
            filter.SortBy = sortBy;
            filter.SortAscending = sortAsc;
            return mapper.Map<PaginatedList<ComplexityLevelTypeViewModel>>(await Service.FindAsync(mapper.Map<IComplexityLevelTypeFilter>(filter)));
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public async Task<ComplexityLevelTypeViewModel> GetAsync(Guid id)
        {
            return mapper.Map<ComplexityLevelTypeViewModel>(await Service.GetAsync(id));
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ComplexityLevelTypeViewModel> PostAsync([FromBody]ComplexityLevelTypeViewModel value)
        {
            return mapper.Map<ComplexityLevelTypeViewModel>(await Service.CreateAsync(mapper.Map<IComplexityLevelType>(value)));
        }

        // PUT api/<controller>/<id>
        [HttpPut]
        public async Task<bool> PutAsync(ComplexityLevelTypeViewModel value)
        {
            return await Service.UpdateAsync(mapper.Map<IComplexityLevelType>(value));
        }

        #endregion Methods
    }
}