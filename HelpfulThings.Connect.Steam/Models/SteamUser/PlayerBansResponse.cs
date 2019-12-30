using System.Collections.Generic;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUser
{
    public class PlayerBansResponse
    {
        [JsonProperty("players")]
        public List<PlayerBanSummary> Players { get; set; }
    }
}