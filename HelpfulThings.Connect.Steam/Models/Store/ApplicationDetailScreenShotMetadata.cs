using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HelpfulThings.Connect.Steam.Models.Store
{
    public class ApplicationDetailScreenShotMetadata
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("path_thumbnail")]
        public Uri ThumbnailUri { get; set; }
        
        [JsonProperty("path_full")]
        public Uri PathFull { get; set; }
    }
}