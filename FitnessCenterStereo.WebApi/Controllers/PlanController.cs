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
    public class PlanController : BaseApiController
    {
        #region Fields

        private readonly IMapper mapper;

        #endregion Fields

        #region Constructors

        public PlanController(IPlanService service, IMapper mapperInterface) : base()
        {
            Service = service;
            mapper = mapperInterface;
        }

        #endregion Constructors

        #region Properties

        protected IPlanService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public async Task<bool> DeleteAsync(Guid id)
        {
            return await Service.DeleteAsync(id);
        }

        public async Task<PaginatedList<PlanViewModel>> FindAsync(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            IPlanFilter filter = new PlanFilter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return mapper.Map<PaginatedList<PlanViewModel>>(await Service.FindAsync(mapper.Map<IPlanFilter>(filter)));
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public async Task<PlanViewModel> GetAsync(Guid id)
        {
            return mapper.Map<PlanViewModel>(await Service.GetAsync(id));
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<PlanViewModel> PostAsync([FromBody]PlanViewModel value)
        {
            return mapper.Map<PlanViewModel>(await Service.CreateAsync(mapper.Map<IPlan>(value)));
        }

        // PUT api/<controller>/<id>
        [HttpPut]
        public async Task<bool> PutAsync(PlanViewModel value)
        {
            return await Service.UpdateAsync(mapper.Map<IPlan>(value));
        }

        #endregion Methods
    }
}