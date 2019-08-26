using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitnessCenterStereo.Common
{
    public class Filter : IFilter
    {

        private int page;
        private int records;

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
            get { return records; }
            set {

                if (String.IsNullOrEmpty(value.ToString())) records = 10;

                else if (value < 10) records = 10;
                else if (value > 100) records = 100;
                else records = value;

            }
        }
    }
}
