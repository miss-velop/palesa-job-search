using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasaltProject.SearchJobModel
{
    public class CompanySearchResponse
    {



        public string Status { get; set; }
        public string RequestId { get; set; }
        public string Query { get; set; }
        public string Language { get; set; }
        public string Region { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public int Zoom { get; set; }
        public int Limit { get; set; }
        public List<CompanyData> Data { get; set; }

        public class CompanyData
        {
            public string BusinessId { get; set; }
            public string GoogleId { get; set; }
            public string PlaceId { get; set; }
            public string PhoneNumber { get; set; }
            public string Name { get; set; }
            public double Latitude { get; set; }
            public double Longitude { get; set; }
            public string FullAddress { get; set; }
            public int ReviewCount { get; set; }
            public double Rating { get; set; }
            public string Timezone { get; set; }
            public object WorkingHours { get; set; }
            public string Website { get; set; }
            public bool Verified { get; set; }
            public string PlaceLink { get; set; }
            public string Cid { get; set; }
            public string ReviewsLink { get; set; }
            public string OwnerId { get; set; }
            public string OwnerLink { get; set; }
            public string OwnerName { get; set; }
            public object BookingLink { get; set; }
            public object ReservationsLink { get; set; }
            public string BusinessStatus { get; set; }
            public string Type { get; set; }
            public List<string> Subtypes { get; set; }
            public List<string> PhotosSample { get; set; }
            public Dictionary<string, int> ReviewsPerRating { get; set; }
            public int PhotoCount { get; set; }
            public object About { get; set; }
            public string Address { get; set; }
            public object OrderLink { get; set; }
            public object PriceLevel { get; set; }
            public string District { get; set; }
            public string StreetAddress { get; set; }
            public string City { get; set; }
            public string Zipcode { get; set; }
            public string State { get; set; }
            public string Country { get; set; }
        }
    }

    




}
