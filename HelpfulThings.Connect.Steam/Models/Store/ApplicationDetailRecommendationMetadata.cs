using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.Store
{
    public class ApplicationDetailRecommendationMetadata
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}