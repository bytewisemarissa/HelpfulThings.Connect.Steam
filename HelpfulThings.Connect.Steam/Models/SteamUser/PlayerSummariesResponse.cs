using System.Collections.Generic;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUser
{
    public class PlayerSummariesResponse
    {
        [JsonProperty("players")]
        public List<PlayerSummary> Players { get; set; }
    }
}