using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUserStats
{
    public class GlobalStatsSummary
    {
        [JsonProperty("total")]
        public long Total { get; set; }
    }
}