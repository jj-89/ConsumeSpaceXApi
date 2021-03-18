using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumeSpaceXApi
{
    class Launch
    {
        public int FlightNumber { get; set; }
        public string MissionName { get; set; }
        public bool Upcomming { get; set; }
        public DateTime LaunchDateUtc { get; set; }
    }
}
