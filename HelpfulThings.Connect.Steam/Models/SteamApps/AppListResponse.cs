using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HelpfulThings.Connect.Steam.Models.SteamApps
{
    public class AppListResponse
    {
        [JsonProperty("apps")]
        public List<ApplicationInformation> Applications { get; set; }
    }
}