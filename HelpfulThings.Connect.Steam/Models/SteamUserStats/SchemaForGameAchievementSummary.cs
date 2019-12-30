using System;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUserStats
{
    public class SchemaForGameAchievementSummary
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("defaultvalue")]
        public long DefaultValue { get; set; }
        
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        
        [JsonProperty("hidden")]
        public bool IsHidden { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }
        
        [JsonProperty("icon")]
        public Uri IconUri { get; set; }
        
        [JsonProperty("icongray")]
        public Uri IconGrayUri { get; set; }
    }
}