using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamNews
{
    public class NewsForApplicationWrapper
    {
        [JsonProperty("appnews")]
        public NewsForApplicationResponse Response { get; set; }
    }
}