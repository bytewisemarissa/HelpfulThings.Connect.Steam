using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUserStats
{
    public class UserStatsForGameAchievementSummary
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("achieved")]
        public bool IsAchieved { get; set; }
    }
}