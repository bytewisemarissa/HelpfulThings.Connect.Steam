using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUserStats
{
    public class UserStatsForGameWrapper
    {
        [JsonProperty("playerstats")]
        public UserStatsForGameResponse Response { get; set; }
    }
}