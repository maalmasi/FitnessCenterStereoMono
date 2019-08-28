using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common.Infrastracture.Pagination
{
    public class PaginatedList<T> where T : IBaseModel
    {
        public int Page { get; private set; }
        public int TotalItems { get; private set; }
        public int RecordsPerPage { get; private set; }
        public IEnumerable<T> Items { get; private set; }

        public PaginatedList(IEnumerable<T> items, int count, int page, int pageSize)
        {
            Page = page;
            TotalItems = count;
            RecordsPerPage = pageSize;
            Items = items;
        }

    }
}
