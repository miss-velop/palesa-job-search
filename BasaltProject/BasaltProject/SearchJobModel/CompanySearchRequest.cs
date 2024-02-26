using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasaltProject.SearchJobModel
{
    public class CompanySearchRequest
    {

        // Header Parameters
        public string X_RapidAPI_Key { get; set; }
        public string X_RapidAPI_Host { get; set; }

        // Required Parameters
        public string Query { get; set; }

        // Optional Parameters
        public int? limit { get; set; }
        public int? lat { get; set; }
        public string? lng { get; set; }
        public string? fields { get; set; }
        public string? business_status { get; set; }
        public string? subtypes { get; set; }
        public string? region { get; set; }
        public bool? verified { get; set; }



    }
}
