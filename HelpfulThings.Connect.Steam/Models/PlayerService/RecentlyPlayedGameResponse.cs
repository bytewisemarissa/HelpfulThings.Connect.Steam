using System.Collections.Generic;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.PlayerService
{
    public class RecentlyPlayedGameResponse
    {
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
        
        [JsonProperty("games")]
        public List<RecentlyPlayerGame> RecentlyPlayedGames { get; set; } 
    }
}