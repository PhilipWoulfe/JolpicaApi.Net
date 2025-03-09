using System;
using System.Globalization;
using Newtonsoft.Json;

namespace JolpicaApi.Serialization.Converters
{
    /// <summary>
    /// Converts a TimeSpan to and from JSON, representing the TimeSpan in seconds.
    /// </summary>
    public class SecondsTimeSpanConverter : JsonConverter
    {
        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The JsonWriter to write to.</param>
        /// <param name="value">The value to write.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var timespan = (TimeSpan)value;
            writer.WriteValue(timespan.TotalMilliseconds);
        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The JsonReader to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The object value.</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Float)
            {
                var milliseconds = (double)reader.Value;
                return TimeSpan.FromSeconds(milliseconds);
            }

            if (reader.TokenType == JsonToken.String)
            {
                var milliseconds = double.Parse((string)reader.Value, CultureInfo.InvariantCulture);
                return TimeSpan.FromSeconds(milliseconds);
            }

            throw new JsonException($"Wrong token type '{reader.TokenType}' for reading TimeStamp as seconds.");
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
