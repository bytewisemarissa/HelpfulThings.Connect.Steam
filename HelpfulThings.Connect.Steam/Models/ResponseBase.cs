using Newtonsoft.Json;

namespace HelpfulThings.Connect.Steam.Models
{
    public class ResponseBase<T>
    {
        [JsonProperty("response")]
        public T Response { get; set; }
    }
}