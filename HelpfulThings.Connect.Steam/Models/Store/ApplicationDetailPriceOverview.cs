using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HelpfulThings.Connect.Steam.Models.Store
{
    public class ApplicationDetailPriceOverview
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }
        
        [JsonProperty("initial")]
        public int InitialCents { get; set; }
        
        [JsonProperty("final")]
        public int FinalCents { get; set; }
        
        [JsonProperty("discount_percent")]
        public int DiscountPercent { get; set; }
        
        [JsonProperty("initial_formatted")]
        public string InitialFormatted { get; set; }
        
        [JsonProperty("final_formatted")]
        public string FinalFormatted { get; set; }
    }
}