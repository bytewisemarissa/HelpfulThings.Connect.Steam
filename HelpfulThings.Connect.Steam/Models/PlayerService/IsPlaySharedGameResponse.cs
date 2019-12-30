using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.PlayerService
{
    public class IsPlaySharedGameResponse
    {
        [JsonIgnore]
        public bool IsPlayingSharedGame => LenderSteamId != "0";
        
        [JsonProperty("lender_steamid")]
        public string LenderSteamId { get; set; }
    }
}