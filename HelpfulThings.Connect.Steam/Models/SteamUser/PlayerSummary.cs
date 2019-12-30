using System;
using HelpfulThings.Connect.Steam.Enums;
using HelpfulThings.DataTypes.Unix;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUser
{
    public class PlayerSummary
    {
        [JsonProperty("steamid")]
        public string SteamId { get; set; }
        
        [JsonProperty("communityvisibilitystate")]
        public CommunityVisibleState CommunityVisibilityState { get; set; }
        
        [JsonProperty("profilestate")]
        public ProfileState ProfileState { get; set; }
        
        [JsonProperty("personaname")]
        public string PersonaName { get; set; }
        
        [JsonProperty("lastlogoff")]
        public UnixTimeStamp LastLogoff { get; set; }
        
        [JsonProperty("commentpermission")]
        public bool CommentsEnabled { get; set; }
        
        [JsonProperty("profileurl")]
        public Uri ProfileUrl { get; set; }
        
        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }
        
        [JsonProperty("avatarmedium")]
        public Uri AvatarMedium { get; set; }
        
        [JsonProperty("avatarfull")]
        public Uri AvatarFull { get; set; }
        
        [JsonProperty("personastate")]
        public PersonaState PersonaState { get; set; }
        
        [JsonProperty("realname")]
        public string RealName { get; set; }
        
        [JsonProperty("primaryclanid")]
        public long PrimaryClanId { get; set; }
        
        [JsonProperty("timecreated")]
        public UnixTimeStamp TimeCreated { get; set; }
        
        [JsonProperty("personastateflags")]
        public long PersonaStateFlags { get; set; }
        
        [JsonProperty("loccountrycode")]
        public string LocationCountryCode { get; set; }
        
        [JsonProperty("locstatecode")]
        public string LocationStateCode { get; set; }
        
        [JsonProperty("loccityid")]
        public int LocationCityId { get; set; }
    }
}