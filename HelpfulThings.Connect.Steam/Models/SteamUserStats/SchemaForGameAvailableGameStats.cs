using System.Collections.Generic;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUserStats
{
    public class SchemaForGameAvailableGameStats
    {
        [JsonProperty("achievements")]
        public List<SchemaForGameAchievementSummary> Achievements { get; set; }
        
        [JsonProperty("stats")]
        public List<SchemaForGameStatsSummary> Statistics { get; set; }
    }
}