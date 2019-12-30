using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUserStats
{
    public class SchemaForGameStatsSummary
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("defaultvalue")]
        public long DefaultValue { get; set; }
        
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }
}