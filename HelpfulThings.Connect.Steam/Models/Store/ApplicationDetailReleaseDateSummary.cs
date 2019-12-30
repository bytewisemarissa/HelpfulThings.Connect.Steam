using System;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.Store
{
    public class ApplicationDetailReleaseDateSummary
    {
        [JsonProperty("coming_soon")]
        public bool IsComingSoon { get; set; }
        
        [JsonProperty("date")]
        public DateTime Date { get; set; }
    }
}