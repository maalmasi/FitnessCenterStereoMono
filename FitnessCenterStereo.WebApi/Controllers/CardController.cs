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
    public class CardController : BaseApiController
    {
        #region Fields

        private readonly IMapper mapper;

        #endregion Fields

        #region Constructors

        public CardController(ICardService service, IMapper mapper)
        {
            Service = service;
            this.mapper = mapper;
        }

        #endregion Constructors

        #region Properties

        protected ICardService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public async Task<bool> DeleteAsync(Guid id)
        {
            return await Service.DeleteAsync(id);
        }

        [HttpGet]
        public async Task<PaginatedList<CardViewModel>> FindAsync(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            ICardFilter filter = new CardFilter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return mapper.Map<PaginatedList<CardViewModel>>(await Service.FindAsync(filter));
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public async Task<CardViewModel> GetAsync(Guid id)
        {
            return mapper.Map<CardViewModel>(await Service.GetAsync(id));
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<CardViewModel> PostAsync([FromBody] CardViewModel value)
        {
            return mapper.Map<CardViewModel>(await Service.CreateAsync(mapper.Map<ICard>(value)));
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public async Task<bool> Put(CardViewModel value)
        {
            return await Service.UpdateAsync(mapper.Map<ICard>(value));
        }

        #endregion Methods
    }
}