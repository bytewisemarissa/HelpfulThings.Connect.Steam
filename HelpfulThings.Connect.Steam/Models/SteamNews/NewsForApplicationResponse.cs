using System.Collections.Generic;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.SteamNews
{
    public class NewsForApplicationResponse
    {
        [JsonProperty("appid")]
        public int ApplicationId { get; set; }
        
        [JsonProperty("newsitems")]
        public List<NewsItem> NewItems { get; set; }
        
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}