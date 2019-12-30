using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUserStats
{
    public class UserStatsForGameStatsSummary
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("value")]
        public long Value { get; set; }
    }
}