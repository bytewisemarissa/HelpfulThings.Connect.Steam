using System.Collections.Generic;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUserStats
{
    public class UserStatsForGameResponse
    {
        [JsonProperty("steamID")]
        public string SteamId { get; set; }
        
        [JsonProperty("gameName")]
        public string GameName { get; set; }
        
        [JsonProperty("stats")]
        public List<UserStatsForGameStatsSummary> Statistics { get; set; }
        
        [JsonProperty("achievements")]
        public List<UserStatsForGameAchievementSummary> Achievements { get; set; }
    }
}