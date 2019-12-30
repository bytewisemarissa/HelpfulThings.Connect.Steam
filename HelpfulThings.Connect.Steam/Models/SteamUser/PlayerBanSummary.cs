using HelpfulThings.Connect.Steam.Enums;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamUser
{
    public class PlayerBanSummary
    {
        [JsonProperty("SteamId")]
        public string SteamId { get; set; }
        
        [JsonProperty("CommunityBanned")]
        public bool CommunityBanned { get; set; }
        
        [JsonProperty("VACBanned")]
        // ReSharper disable once InconsistentNaming
        public bool IsVACBanned { get; set; }
        
        [JsonProperty("NumberOfVACBans")]
        // ReSharper disable once InconsistentNaming
        public int NumberOfVACBans { get; set; }
        
        [JsonProperty("DaysSinceLastBan")]
        public int DaysSinceLastBan { get; set; }
        
        [JsonProperty("NumberOfGameBans")]
        public int NumberOfGameBans { get; set; }
        
        [JsonProperty("EconomyBan")]
        public EconomyBanStatus EconomyBanStatus { get; set; }
    }
}