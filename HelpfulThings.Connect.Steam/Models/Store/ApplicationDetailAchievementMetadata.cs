using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.Store
{
    public class ApplicationDetailAchievementMetadata
    {
        [JsonProperty("total")]
        public int Total { get; set; }
        
        [JsonProperty("highlighted")]
        public ApplicationDetailHighlightedAchievementSummary[] HighlightedAchievements { get; set; }
    }
}