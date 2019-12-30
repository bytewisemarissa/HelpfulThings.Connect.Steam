using System.Collections.Generic;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUserStats
{
    public class PlayerAchievementsResponse
    {
        [JsonProperty("steamID")]
        public string SteamId { get; set; }
        
        [JsonProperty("gameName")]
        public string GameName { get; set; }
        
        [JsonProperty("achievements")]
        public List<PlayerAchievementSummary> Achievements { get; set; }
        
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}