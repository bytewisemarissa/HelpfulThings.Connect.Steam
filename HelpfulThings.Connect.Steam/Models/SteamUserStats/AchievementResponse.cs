using System.Collections.Generic;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUserStats
{
    public class AchievementResponse
    {
        [JsonProperty("achievements")]
        public List<AchievementSummary> Achievements { get; set; }
    }
}