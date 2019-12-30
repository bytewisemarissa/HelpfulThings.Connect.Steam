using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.Store
{
    public class ApplicationDetailContentDescriptorsSummary
    {
        [JsonProperty("ids")]
        public int[] Ids { get; set; }
        
        [JsonProperty("notes")]
        public string Notes { get; set; }
    }
}