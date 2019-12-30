using HelpfulThings.DataTypes.Unix;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HelpfulThings.Connect.Steam.Models.SteamUser
{
    public class FriendSummary
    {
        [JsonProperty("steamid")]
        public string SteamId { get; set; }
        
        [JsonProperty("relationship")]
        public string RelationshipQualifier { get; set; }
        
        [JsonProperty("friend_since")]
        public UnixTimeStamp FriendSince { get; set; }
    }
}