using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.PlayerService
{
    public class RecentlyPlayerGame
    {
        [JsonProperty("appid")]
        public long ApplicationId { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("playtime_2weeks")]
        public int PlayTimeTwoWeeksMinutes { get; set; }
        
        [JsonProperty("playtime_forever")]
        public int PlayTimeForeverMinutes { get; set; }
        
        [JsonProperty("img_icon_url")]
        public string IconUrl { get; set; }
        
        [JsonProperty("img_logo_url")]
        public string LogoUrl { get; set; }
        
        [JsonProperty("playtime_windows_forever")]
        public int PlayTimeWindowsForeverMinutes { get; set; }
        
        [JsonProperty("playtime_mac_forever")]
        public int PlayTimeMacForeverMinutes { get; set; }
        
        [JsonProperty("playtime_linux_forever")]
        public int PlayTimeLinuxForeverMinutes { get; set; }
    }
}