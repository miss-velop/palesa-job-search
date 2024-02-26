using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BasaltProject.SearchJobModel
{
    public class JSearchResponse
    {


        public class JobResponse
        {
            public string Status { get; set; }
            public string RequestId { get; set; }
            public Parameters Parameters { get; set; }
            [JsonProperty("data")]
            public List<JobData> Data { get; set; }
        }

        public class Parameters
        {
            public string Query { get; set; }
            public int Page { get; set; }
            public int NumPages { get; set; }
        }

       

        public class ApplyOption
        {
            [JsonProperty("publisher")]
            public string Publisher { get; set; }

            [JsonProperty("apply_link")]
            public string ApplyLink { get; set; }

            [JsonProperty("is_direct")]
            public bool IsDirect { get; set; }
        }

        public class JobData
        {
            [JsonProperty("job_id")]
            public string JobId { get; set; }

            [JsonProperty("employer_name")]
            public string EmployerName { get; set; }

            [JsonProperty("employer_logo")]
            public object EmployerLogo { get; set; }

            [JsonProperty("employer_website")]
            public object EmployerWebsite { get; set; }

            [JsonProperty("employer_company_type")]
            public object EmployerCompanyType { get; set; }

            [JsonProperty("job_publisher")]
            public string JobPublisher { get; set; }

            [JsonProperty("job_employment_type")]
            public string JobEmploymentType { get; set; }

            [JsonProperty("job_title")]
            public string JobTitle { get; set; }

            [JsonProperty("job_apply_link")]
            public string JobApplyLink { get; set; }
            [JsonProperty("job_offer_expiration_timestamp")]
            public int? JobOfferExpirationTimestamp { get; set; }


            [JsonProperty("job_apply_is_direct")]
            public bool JobApplyIsDirect { get; set; }

            [JsonProperty("job_apply_quality_score")]
            public double JobApplyQualityScore { get; set; }

            [JsonProperty("apply_options")]
            public List<ApplyOption> ApplyOptions { get; set; }

            [JsonProperty("job_description")]
            public string JobDescription { get; set; }

            [JsonProperty("job_is_remote")]
            public bool JobIsRemote { get; set; }

            [JsonProperty("job_posted_at_timestamp")]
            public int JobPostedAtTimestamp { get; set; }

            [JsonProperty("job_posted_at_datetime_utc")]
            public string JobPostedAtDatetimeUtc { get; set; }

            [JsonProperty("job_city")]
            public string JobCity { get; set; }

            [JsonProperty("job_state")]
            public string JobState { get; set; }

            [JsonProperty("job_country")]
            public string JobCountry { get; set; }

            [JsonProperty("job_latitude")]
            public double? JobLatitude { get; set; }

            [JsonProperty("job_longitude")]
            public double? JobLongitude { get; set; }

            [JsonProperty("job_benefits")]
            public object? JobBenefits { get; set; }

            [JsonProperty("job_google_link")]
            public string? JobGoogleLink { get; set; }

            [JsonProperty("job_offer_expiration_datetime_utc")]
            public string? JobOfferExpirationDatetimeUtc { get; set; }

            

            [JsonProperty("job_required_experience")]
            public object? JobRequiredExperience { get; set; }

            [JsonProperty("job_required_skills")]
            public object? JobRequiredSkills { get; set; }

            [JsonProperty("job_required_education")]
            public object? JobRequiredEducation { get; set; }

            [JsonProperty("job_experience_in_place_of_education")]
            public bool? JobExperienceInPlaceOfEducation { get; set; }

            [JsonProperty("job_min_salary")]
            public object? JobMinSalary { get; set; }

            [JsonProperty("job_max_salary")]
            public object JobMaxSalary { get; set; }

            [JsonProperty("job_salary_currency")]
            public object JobSalaryCurrency { get; set; }

            [JsonProperty("job_salary_period")]
            public object JobSalaryPeriod { get; set; }

            [JsonProperty("job_highlights")]
            public object JobHighlights { get; set; }

            [JsonProperty("job_job_title")]
            public string JobJobTitle { get; set; }

            [JsonProperty("job_posting_language")]
            public string JobPostingLanguage { get; set; }

            [JsonProperty("job_onet_soc")]
            public string JobOnetSoc { get; set; }

            [JsonProperty("job_onet_job_zone")]
            public string JobOnetJobZone { get; set; }
        }

    }

}

