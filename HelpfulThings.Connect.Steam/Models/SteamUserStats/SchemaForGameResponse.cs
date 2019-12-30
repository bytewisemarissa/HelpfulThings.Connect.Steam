using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUserStats
{
    public class SchemaForGameResponse
    {
        [JsonProperty("gameName")]
        public string GameName { get; set; }
        
        [JsonProperty("gameVersion")]
        public string GameVersion { get; set; }
        
        [JsonProperty("availableGameStats")]
        public SchemaForGameAvailableGameStats AvailableGameStatistics { get; set; }
    }
}