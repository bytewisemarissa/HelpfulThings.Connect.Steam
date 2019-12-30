using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.PlayerService
{
    public class OwnedGame
    {
        [JsonProperty("appid")]
        public long ApplicationId { get; set; }
        
        [JsonProperty("playtime_forever")]
        public int PlayTimeForeverMinutes { get; set; }
        
        [JsonProperty("playtime_windows_forever")]
        public int PlayTimeWindowsForeverMinutes { get; set; }
        
        [JsonProperty("playtime_mac_forever")]
        public int PlayTimeMacForeverMinutes { get; set; }
        
        [JsonProperty("playtime_linux_forever")]
        public int PlayTimeLinuxForeverMinutes { get; set; }
    }
}