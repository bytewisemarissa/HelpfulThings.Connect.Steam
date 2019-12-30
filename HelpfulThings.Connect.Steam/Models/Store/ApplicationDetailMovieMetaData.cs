using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HelpfulThings.Connect.Steam.Models.Store
{
    public class ApplicationDetailMovieMetaData
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("thumbnail")]
        public Uri ThumbnailUri { get; set; }
        
        [JsonProperty("webm")]
        public Dictionary<string, Uri> WebMovieUris { get; set; }
        
        [JsonProperty("highlight")]
        public bool ShouldHighlight { get; set; }
    }
}