using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.Store
{
    public class ApplicationDetailGameCategory
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}