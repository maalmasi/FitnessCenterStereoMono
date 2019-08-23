using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenterStereo.Common
{
    public interface IFilter
    {
        String SearchQuery { get; set; }
        String SortBy { get; set; }
        bool SortAscending { get; set; }
        int Page { get; set; }
        int RecordsPerPage{ get; set; }
    }
}
