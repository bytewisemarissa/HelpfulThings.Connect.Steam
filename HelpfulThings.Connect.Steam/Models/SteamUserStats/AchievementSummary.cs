using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUserStats
{
    public class AchievementSummary
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("percent")]
        public double Percentage { get; set; }
    }
}