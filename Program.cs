using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsumeSpaceXApi
{
    class Program
    {
        private static readonly HttpClient HttpClient;

        static Program()
        {
            HttpClient = new HttpClient();
        }

        static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello World");
             await GetAllLaunches();
        }

        public static async Task GetAllLaunches()
        {
            string baseUrl = $"https://api.spacexdata.com/v3/launches/1";
            using (HttpClient)
            {
                try
                {
                    string responseBody = await HttpClient.GetStringAsync(baseUrl);

                    var launchData = JObject.Parse(responseBody);

                    //Launch launch = new Launch(flightNumber: (int)launchData["flight_number"], missionName: (string)launchData["mission_name"], upcomming: (int)launchData["upcomming"], launchDateUtc: (DateTime)launchData["launch_date_utc"]);
                    //Console.WriteLine("Flight Number: {0}, \n Mission Name: {1}, \n Upcomming: {2}, \n Launch Date Utc: {3}", launch.FlightNumber, launch.MissionName, launch.Upcomming, launch.LaunchDateUtc);
                    Console.WriteLine("\n Flight Number: {0}, \n Mission Name: {1}, \n Upcomming: {2}, \n Launch Date Utc: {3}",(string)launchData["flight_number"], launchData["mission_name"], launchData["upcomming"], launchData["launch_date_utc"]);
                }
                catch(HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0}", e.Message);
                }
            }
        }

    }
}
