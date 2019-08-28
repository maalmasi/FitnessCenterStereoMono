﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FitnessCenterStereo.Common;
using FitnessCenterStereo.Model.Common;
using FitnessCenterStereo.Service.Common;
using FitnessCenterStereo.WebApi.Infrastracture.Pagination;
using FitnessCenterStereo.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessCenterStereo.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class CardController : BaseApiController
    {
        protected ICardService Service { get; private set; }
        private readonly IMapper mapper;

        public CardController(ICardService service, IMapper mapper)
        {
            Service = service;
            this.mapper = mapper;
        }

        [HttpGet]
        public PaginatedList<CardViewModel> Find(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            Filter filter = new Filter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return mapper.Map<PaginatedList<CardViewModel>>(Service.Find(filter));
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public CardViewModel Get(Guid id)
        {
            return mapper.Map<CardViewModel>(Service.Get(id));
        }

        // POST api/<controller>
        [HttpPost]
        public CardViewModel Post([FromBody] CardViewModel value)
        {
            return mapper.Map<CardViewModel>(Service.Create(mapper.Map<ICard>(value)));
        }

        // PUT api/<controller>/<id>
        [HttpPut("{id}")]
        public bool Put(CardViewModel value)
        {
            return Service.Update(mapper.Map<ICard>(value));
        }

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return Service.Delete(id);
        }
    }

}
