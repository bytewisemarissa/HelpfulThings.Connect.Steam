using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HelpfulThings.Connect.Steam.Models.SteamApps
{
    public class ApplicationInformation
    {
        [JsonProperty("appid")]
        public int ApplicationId { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}