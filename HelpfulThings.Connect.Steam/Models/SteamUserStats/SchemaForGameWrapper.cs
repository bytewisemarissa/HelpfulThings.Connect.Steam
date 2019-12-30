using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUserStats
{
    public class SchemaForGameWrapper
    {
        [JsonProperty("game")]
        public  SchemaForGameResponse Response { get; set; }
    }
}