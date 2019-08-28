using FitnessCenterStereo.WebApi.Controllers;
using FitnessCenterStereo.WebApi.Models;
using System;
using System.Collections.Generic;

namespace FitnessCenterStereo.WebApi.Infrastracture.Pagination
{
        public class PaginatedList<T> where T : BaseViewModel
        {
            public int Page { get; private set; }
            public int TotalItems { get; private set; }
            public int RecordsPerPage { get; private set; }
            public IEnumerable<T> Items { get; private set; }

            public PaginatedList(IEnumerable<T> items, int page, int totalItems, int recordsPerPage)
            {
                Page = page;
                TotalItems = totalItems;
                RecordsPerPage = recordsPerPage;
                Items = items;
            }
    }
}
