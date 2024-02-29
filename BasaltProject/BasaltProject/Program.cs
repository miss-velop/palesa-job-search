using System;
using RestSharp;
using System.Net.Http.Headers;
using BasaltProject.SearchJobModel;
using System.Reflection.Metadata.Ecma335;
using System.Diagnostics.Metrics;
using System.Net;
using Newtonsoft.Json;
using static BasaltProject.SearchJobModel.JSearchResponse;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("WELCOME TO PALESA JOB Search API PROJECT");
            Console.WriteLine("Please Enter job title:");
            string JobTittle = Console.ReadLine();
            Console.WriteLine("Please Enter Country title:");
            var Country = Console.ReadLine();
            var apiUrl = $"https://jsearch.p.rapidapi.com/search?query={Uri.EscapeDataString(JobTittle)} in {Uri.EscapeDataString(Country)}&page=1&num_pages=1";
            var jSearchRequest = new JSearchRequest
            {

                X_RapidAPI_Host = "jsearch.p.rapidapi.com",
                Query = $"{JobTittle} in {Country}",
                Page = 1,
                Num_Pages = 1,
                Date_Posted = DatePostedEnum.All,
                Remote_Jobs_Only = false,
                // ... other parameters
            };
            GetSearchByJob(apiUrl, jSearchRequest);
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
        
        }
         

    }

    static string GetSearchByJob(string apiUrl, JSearchRequest requestData)
    {

        try
        {
        var request = new RestRequest();
        var client = new RestClient(apiUrl);
        request.Method = Method.Get;


        request.AddHeader("X-RapidAPI-Key", "561e03ff29mshe3c5ccc432a600ep136405jsn4411d02181a7");
        request.AddHeader("X-RapidAPI-Host", "jsearch.p.rapidapi.com");

        request.AddQueryParameter("query", requestData.Query);

        var response = client.Execute(request);
        var JResponse = JsonConvert.DeserializeObject<JobResponse>(response.Content);
            //Check if response is not null
            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {

                 for (int i = 0; i < JResponse.Data.Count; i++)
                 {

                //Print out the Job
                Console.WriteLine("##############################################################");

                Console.WriteLine("Job Tittle:" + JResponse.Data[i].JobTitle);
                Console.WriteLine("Employer Name :" + JResponse.Data[i].EmployerName);
                Console.WriteLine("Job Description" + JResponse.Data[i].JobDescription);
                Console.WriteLine("Employer Company type :" + JResponse.Data[i].EmployerCompanyType);
                Console.WriteLine("Job Salary Period" + JResponse.Data[i].JobSalaryPeriod);
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Would you like to know more about the Employer: (Y/N)");
                var companyName= JResponse.Data[i].EmployerName.ToString();
                var JobLink= JResponse.Data[i].JobApplyLink.ToString();
            // Capture a single key press
                ConsoleKeyInfo key = Console.ReadKey();
                // Check the pressed key
                if (key.Key == ConsoleKey.Y)
                {
                    Console.WriteLine("\nYou pressed 'Y'. Geting Company info...");
                    Console.WriteLine("Fetching data...");
                    GetCompanyByNameb(apiUrl, companyName,JobLink);
                }
                else if (key.Key == ConsoleKey.N)
                {
                    Console.WriteLine("\nYou pressed 'N'. ");
                   
                }
            
                
                }
            Console.ReadLine();
        }

        return response.Content.ToString();
        }

        catch (Exception ex)
       
        {
            Console.WriteLine(ex.Message);
            return "";
        }



    }
    static string GetCompanyByNameb(string apiUrl, string Company_Name, string JobLink)
    {
        try
        { 
            apiUrl = $"https://local-business-data.p.rapidapi.com/search?{Uri.EscapeDataString(Company_Name)}&page=1&num_pages=1";
        var request = new RestRequest();
        var client = new RestClient(apiUrl);
        request.Method = Method.Get;



        request.AddHeader("X-RapidAPI-Key", "561e03ff29mshe3c5ccc432a600ep136405jsn4411d02181a7");
        request.AddHeader("X-RapidAPI-Host", "local-business-data.p.rapidapi.com");

        request.AddQueryParameter("query", Company_Name);

        var response = client.Execute(request);

            if (response != null)
            {
                var CResponse = JsonConvert.DeserializeObject<CompanySearchResponse>(response.Content);
                for (int i = 0; i < CResponse.Data.Count; i++)
                {

                    //Print out the Comany Info
                    Console.WriteLine("#####################Company Infomation#########################################");
                    Console.WriteLine("Company Name:" + CResponse.Data[i].Name);
                    Console.WriteLine("About :" + CResponse.Data[i].About);
                    Console.WriteLine("Adress" + CResponse.Data[i].Address);
                    Console.WriteLine("Website:" + CResponse.Data[i].Website);
                    Console.WriteLine("Business Status" + CResponse.Data[i].BusinessStatus);
                    Console.WriteLine("Company Type" + CResponse.Data[i].Type);
                    Console.WriteLine("#############################################################");
                    Console.WriteLine("Would you like to apply to the Job: (Y/N)");

                    ConsoleKeyInfo key = Console.ReadKey();
                    // Check the pressed key
                    
                    
                    if (key.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine("\nHere is the Link Below");
                        Console.WriteLine("Fetching data...");
                        Console.WriteLine(JobLink);

                    }
                    else if (key.Key == ConsoleKey.N)
                    {
                        Console.WriteLine(">>>>>>>>>>>>>>>Goood Luck!!!>>>>>>>>>>>>>>>>>>>>>>>>");
                        i++;
                    }
                }


                Console.WriteLine(">>>>>>>>>>>>>>>Goood Luck>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine(">>>>>>>>>>>>>>>Press Any Key to End!!!!!!!!!!>>>>>>>>>>>>>>>>>>>>>>>>");

                Console.ReadLine();
            }
                return response.Content.ToString();
        }
        
         catch (Exception ex)
        {
            //Handle the error.
            Console.WriteLine(ex.Message);
            return "";
        }
    }
}
