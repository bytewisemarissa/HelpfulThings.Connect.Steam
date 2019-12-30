using System.Collections.Generic;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUser
{
    public class FriendListResponse
    {
        [JsonProperty("friends")]
        public List<FriendSummary> Friends { get; set; }
    }
}