using HelpfulThings.DataTypes.Unix;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUserStats
{
    public class PlayerAchievementSummary
    {
        [JsonProperty("apiname")]
        public string ApiName { get; set; }
        
        [JsonProperty("achieved")]
        public bool IsAchieved { get; set; }
        
        [JsonProperty("UnlockTime")]
        public UnixTimeStamp UnlockTime { get; set; }
    }
}