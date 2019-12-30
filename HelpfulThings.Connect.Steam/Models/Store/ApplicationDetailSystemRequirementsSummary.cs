using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.Store
{
    public class ApplicationDetailSystemRequirementsSummary
    {
        [JsonProperty("minimum")]
        public string Minimum { get; set; }
        
        [JsonProperty("recommended")]
        public string Recommended { get; set; }
    }
}