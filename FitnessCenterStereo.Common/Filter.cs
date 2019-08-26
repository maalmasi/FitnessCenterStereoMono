using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitnessCenterStereo.Common
{
    public class Filter : IFilter
    {
  
        public string SearchQuery { get ; set; }
        public string SortBy { get; set; }
        public bool SortAscending { get; set; }
        public int Page { get; set; }
        public int RecordsPerPage { get; set; }
    }
}
