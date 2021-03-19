using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumeSpaceXApi
{
    public class Launch
    {

        public Launch()
        {

        }
        public Launch(int flightNumber, string missionName, string upcomming, DateTime launchDateUtc)
        {
            FlightNumber = flightNumber;
            MissionName = missionName;
            Upcomming = upcomming;
            LaunchDateUtc = launchDateUtc;
        }

        public int FlightNumber { get; set; }
        public string MissionName { get; set; }
        public string Upcomming { get; set; }
        public DateTime LaunchDateUtc { get; set; }
    }
}
