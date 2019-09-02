using AutoMapper;
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
    public class MembershipController : BaseApiController
    {
        #region Fields

        private readonly IMapper mapper;

        #endregion Fields

        #region Constructors

        public MembershipController(IMembershipService service, IMapper mapperInterface) : base()
        {
            Service = service;
            mapper = mapperInterface;
        }

        #endregion Constructors

        #region Properties

        protected IMembershipService Service { get; private set; }

        #endregion Properties

        #region Methods

        // DELETE api/<controller>/<id>
        [HttpDelete("{id}")]
        public Task<bool> DeleteAsync(Guid id)
        {
            return Service.DeleteAsync(id);
        }

        public async Task<PaginatedList<MembershipViewModel>> FindAsync(string searchQuerry = DefaultSearchQuerry, int page = DefaultPage, int rpp = DefaultRpp, string sortBy = DefaultSortBy, bool sortAsc = DefaultSortAsc)
        {
            IMembershipFilter filter = new MembershipFilter() { SearchQuery = searchQuerry, Page = page, RecordsPerPage = rpp, SortAscending = sortAsc, SortBy = sortBy };
            return mapper.Map<PaginatedList<MembershipViewModel>>(await Service.FindAsync(mapper.Map<IMembershipFilter>(filter)));
        }

        // GET api/<controller>/<id>
        [HttpGet("{id}")]
        public async Task<MembershipViewModel> GetAsync(Guid id)
        {
            return mapper.Map<MembershipViewModel>(await Service.GetAsync(id));
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<MembershipViewModel> PostAsync([FromBody]MembershipViewModel value)
        {
            return mapper.Map<MembershipViewModel>(await Service.CreateAsync(mapper.Map<IMembership>(value)));
        }

        // PUT api/<controller>/<id>
        [HttpPut]
        public async Task<bool> PutAsync(MembershipViewModel value)
        {
            return await Service.UpdateAsync(mapper.Map<IMembership>(value));
        }

        #endregion Methods
    }
}