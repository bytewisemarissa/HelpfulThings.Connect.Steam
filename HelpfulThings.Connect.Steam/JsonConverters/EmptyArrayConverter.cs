using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HelpfulThings.Connect.Steam.JsonConverters
{
    public class EmptyArrayConverter<T> : JsonConverter<T>
    {
        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var token = JToken.Load(reader);

            if (!token.Any())
            {
                return default(T);
            }

            return JsonConvert.DeserializeObject<T>(token.ToString());
        }
    }
}