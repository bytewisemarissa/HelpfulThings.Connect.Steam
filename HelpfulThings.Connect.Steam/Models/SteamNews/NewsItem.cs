using System;
using HelpfulThings.DataTypes.Unix;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HelpfulThings.Connect.Steam.Models.SteamNews
{
    public class NewsItem
    {
        [JsonProperty("gid")]
        public string Gid { get; set; }
        
        [JsonProperty("title")]
        public string Title { get; set; }
        
        [JsonProperty("url")]
        public Uri Uri { get; set; }
        
        [JsonProperty("is_external_url")]
        public bool IsExternalUrl { get; set; }
        
        [JsonProperty("author")]
        public string Author { get; set; }
        
        [JsonProperty("contents")]
        public string Contents { get; set; }
        
        [JsonProperty("feedlabel")]
        public string FeedLabel { get; set; }
        
        [JsonProperty("date")]
        public UnixTimeStamp Date { get; set; }
        
        [JsonProperty("feedname")]
        public string FeedName { get; set; }
        
        [JsonProperty("feed_type")]
        public int FeedType { get; set; }
        
        [JsonProperty("appid")]
        public int ApplicationId { get; set; } 
    }
}