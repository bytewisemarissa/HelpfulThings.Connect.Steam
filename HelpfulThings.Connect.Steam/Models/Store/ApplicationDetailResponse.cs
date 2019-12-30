using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.Store
{
    public class ApplicationDetailResponse
    {
        [JsonProperty("success")]
        public bool WasSuccess { get; set; }
        
        [JsonProperty("data")]
        public ApplicationDetail ApplicationDetail { get; set; }
    }
}