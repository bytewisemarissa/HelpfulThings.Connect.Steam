using System.Collections.Generic;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUserStats
{
    public class GlobalStatsResponse
    {
        [JsonProperty("globalstats")]
        public Dictionary<string, GlobalStatsSummary> GlobalStatistics { get; set; }
        
        [JsonProperty("result")]
        public long Result { get; set; }
    }
}