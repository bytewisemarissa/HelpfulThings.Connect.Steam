using System;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.Store
{
    public class ApplicationDetailSupportInformation
    {
        [JsonProperty("url")]
        public Uri SupportUri { get; set; }
        
        [JsonProperty("email")]
        public string SupportEmail { get; set; }
    }
}