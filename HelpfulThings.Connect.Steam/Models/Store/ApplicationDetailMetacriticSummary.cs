using System;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.Store
{
    public class ApplicationDetailMetacriticSummary
    {
        [JsonProperty("score")]
        public int Score { get; set; }
        
        [JsonProperty("url")]
        public Uri MetacriticUri { get; set; }
    }
}