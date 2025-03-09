using System;
using Newtonsoft.Json;

namespace JolpicaApi.Serialization.Converters
{
    /// <summary>
    /// Converts a TimeSpan to and from its string representation.
    /// </summary>
    public class StringTimeSpanConverter : JsonConverter
    {
        /// <summary>
        /// Gets the array of formats used for parsing TimeSpan strings.
        /// </summary>
        protected virtual string[] Formats =>
        [
                "hh':'mm':'ss",
                "hh':'mm':'ss'.'fff",
                "h':'mm':'ss'.'fff",
                "mm':'ss'.'fff",
                "m':'ss'.'fff"
            ];

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The JsonWriter to write to.</param>
        /// <param name="value">The value to write.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
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
            if (reader.TokenType != JsonToken.String)
                throw new JsonException($"Wrong token type '{reader.TokenType}' for reading TimeStamp in format 'hh:mm:ss.fff'.");

            var value = (string)reader.Value;

            if (value == null)
                return null;

            if (TimeSpan.TryParseExact(value, Formats, null, out var result))
                return result;

            return null;
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
