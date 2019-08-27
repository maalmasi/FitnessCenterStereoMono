using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Model.Common.Infrastracture.Pagination
{
    public class PaginatedList<T> where T : IBaseModel
    {
        public int Page { get; private set; }
        public int TotalPages { get; private set; }
        public int RecordsPerPage { get; private set; }
        public IEnumerable<T> Items { get; private set; }

        public PaginatedList(IEnumerable<T> items, int count, int page, int pageSize)
        {
            Page = page;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            RecordsPerPage = pageSize;
            Items = items;
        }

    }
}
