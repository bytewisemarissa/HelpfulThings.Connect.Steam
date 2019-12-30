using System.Collections.Generic;
using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.PlayerService
{
    public class OwnedGamesResponse
    {
        [JsonProperty("game_count")]
        public int GamesCount { get; set; }
        
        [JsonProperty("games")]
        public List<OwnedGame> OwnedGames { get; set; }
    }
}