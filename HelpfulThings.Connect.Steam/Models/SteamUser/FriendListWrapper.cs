using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUser
{
    public class FriendListWrapper
    {
        [JsonProperty("friendslist")]
        public FriendListResponse Response { get; set; }
    }
}