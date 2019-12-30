using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HelpfulThings.Connect.Steam.Models.SteamApps
{
    public class AppListWrapper
    {
        [JsonProperty("applist")]
        public AppListResponse Response { get; set; }
    }
}