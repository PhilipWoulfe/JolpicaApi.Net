using System;
using Newtonsoft.Json;

namespace JolpicaApi.Serialization.Converters
{
    /// <summary>
    /// Converts a TimeSpan object to and from its JSON representation in milliseconds.
    /// </summary>
    public class MillisecondsTimeSpanConverter : JsonConverter
    {
        /// <summary>
        /// Writes the JSON representation of the TimeSpan object.
        /// </summary>
        /// <param name="writer">The JsonWriter to write to.</param>
        /// <param name="value">The TimeSpan object to write.</param>
        /// <param name="serializer">The JsonSerializer instance.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var timespan = (TimeSpan)value;
            writer.WriteValue(timespan.TotalMilliseconds);
        }

        /// <summary>
        /// Reads the JSON representation of the TimeSpan object.
        /// </summary>
        /// <param name="reader">The JsonReader to read from.</param>
        /// <param name="objectType">The type of the object to read.</param>
        /// <param name="existingValue">The existing value of the object being read.</param>
        /// <param name="serializer">The JsonSerializer instance.</param>
        /// <returns>The TimeSpan object.</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Integer)
            {
                var milliseconds = (long)reader.Value;
                return TimeSpan.FromMilliseconds(milliseconds);
            }

            if (reader.TokenType == JsonToken.String)
            {
                var milliseconds = long.Parse((string)reader.Value);
                return TimeSpan.FromMilliseconds(milliseconds);
            }

            throw new JsonException($"Wrong token type '{reader.TokenType}' for reading TimeStamp as milliseconds.");
        }

        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>true if this instance can convert the specified object type; otherwise, false.</returns>
        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }
    }
}
