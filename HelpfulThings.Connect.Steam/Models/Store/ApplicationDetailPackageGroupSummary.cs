using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models.Store
{
    public class ApplicationDetailPackageGroupSummary
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("title")]
        public string Title { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }
        
        [JsonProperty("selection_text")]
        public string SelectionText { get; set; }
        
        [JsonProperty("save_text")]
        public string SaveText { get; set; }

        [JsonProperty("display_type")]
        public int DisplayType { get; set; }
        
        [JsonProperty("is_recurring_subscription")]
        public bool IsRecurringSubscription { get; set; }
        
        [JsonProperty("subs")]
        public ApplicationDetailPackageGroupSummaryItem[] SubItems { get; set; }
        
        
    }
}