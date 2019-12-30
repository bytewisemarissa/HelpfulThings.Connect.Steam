using System.Threading;

namespace HelpfulThings.Connect.Steam.Metering
{
    public class SteamApiOptions
    {
        public string UserAgent { get; set; }
        public string UserAgentVersion { get; set; }
        public int MeteringPeriodHours { get; set; }
        public int RequestLimit { get; set; }
        public MeteringType MeteringType { get; set; }
        public string ApiKey { get; set; }

        public SteamApiOptions()
        {
            MeteringPeriodHours = 24;
            RequestLimit = 100000;
            MeteringType = MeteringType.EvenSplit;
        }
    }
}