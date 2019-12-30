using System.Collections.Generic;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUserStats
{
    public class AchievementPercentagesWrapper
    {
        [JsonProperty("achievementpercentages")]
        public AchievementResponse Response { get; set; }
    }
}