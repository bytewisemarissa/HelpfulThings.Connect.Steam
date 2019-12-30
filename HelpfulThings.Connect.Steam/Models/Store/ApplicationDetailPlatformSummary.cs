using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.Store
{
    public class ApplicationDetailPlatformSummary
    {
        [JsonProperty("windows")]
        public bool SupportsWindows { get; set; }
        
        [JsonProperty("mac")]
        public bool SupportsMac { get; set; }
        
        [JsonProperty("linux")]
        public bool SupportsLinux { get; set; }
    }
}