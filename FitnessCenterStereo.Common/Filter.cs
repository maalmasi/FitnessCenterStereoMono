using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitnessCenterStereo.Common
{
    public class Filter : IFilter
    {

        private int page;
        private int recordsPerPage;

        public string SearchQuery { get ; set; }
        public string SortBy { get; set; }
        public bool SortAscending { get; set; }
        public int Page {
            get {
                return page;
            }
            set{
                if (value < 1) page = 1;
                else page = value;
            }                         
        }
        public int RecordsPerPage {
            get { return recordsPerPage; }
            set {

                if (String.IsNullOrEmpty(value.ToString())) recordsPerPage = 10;

                else if (value < 10) recordsPerPage = 10;
                else if (value > 100) recordsPerPage = 100;
                else recordsPerPage = value;

            }
        }
    }
}
