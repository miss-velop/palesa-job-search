using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BasaltProject.SearchJobModel
{
    public class JSearchRequest
    {
        // Header Parameters
        public string X_RapidAPI_Key { get; set; }
        public string X_RapidAPI_Host { get; set; }

        // Required Parameters
        public string Query { get; set; }

        // Optional Parameters
        public int? Page { get; set; }
        public int? Num_Pages { get; set; }
        public DatePostedEnum? Date_Posted { get; set; }
        public bool? Remote_Jobs_Only { get; set; }
        public string Employment_Types { get; set; }
        public string Job_Requirements { get; set; }
        public string Job_Titles { get; set; }
        public string Company_Types { get; set; }
        public string Employer { get; set; }
        public bool? Actively_Hiring { get; set; }
        public int? Radius { get; set; }
        public string Categories { get; set; }
        public string Exclude_Job_Publishers { get; set; }
    }

    public enum DatePostedEnum
    {
        All,
        Today,
        ThreeDays,
        Week,
        Month
    }
}
