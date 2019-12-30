using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUserStats
{
    public class PlayerAchievementsWrapper
    {
        [JsonProperty("playerstats")]
        public PlayerAchievementsResponse Response { get; set; }
    }
}