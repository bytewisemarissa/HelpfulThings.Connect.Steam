using System;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.Store
{
    public class ApplicationDetailHighlightedAchievementSummary
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("path")]
        public Uri IconPath { get; set; }
    }
}