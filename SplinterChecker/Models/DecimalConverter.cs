using System;
using Newtonsoft.Json;

namespace SplinterChecker.Models
{
    public class DecimalConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(decimal);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (decimal.TryParse(reader.Value.ToString(), out decimal result))
            {
                return result;
            }
            else
            {
                return 0m; // default value if input string cannot be parsed
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(value);
        }
    }
}
