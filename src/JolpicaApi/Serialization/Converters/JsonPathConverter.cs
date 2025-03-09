using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace JolpicaApi.Serialization.Converters
{
    /// <summary>
    /// A custom JSON converter that allows mapping JSON properties to object properties using JSON paths.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="JsonPathConverter"/> class.
    /// </remarks>
    /// <param name="pathProperties">The collection of JSON path property information.</param>
    public class JsonPathConverter(IEnumerable<JsonPathPropertyInfo> pathProperties) : JsonConverter
    {
        private IEnumerable<JsonPathPropertyInfo> PathProperties { get; } = pathProperties;

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The value to write.</param>
        /// <param name="serializer">The JSON serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The JSON reader.</param>
        /// <param name="objectType">The type of the object.</param>
        /// <param name="existingValue">The existing value of the object being read.</param>
        /// <param name="serializer">The JSON serializer.</param>
        /// <returns>The object value.</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var token = JObject.Load(reader);

            if (serializer.ContractResolver.ResolveContract(objectType) is not JsonObjectContract contract)
                throw new InvalidOperationException("JsonPathConverter cannot be used with value types or arrays.");

            // This is done to avoid an infinite loop by calling this same converter for the root object
            var value = CreateRootObject(token, contract, serializer);

            foreach (var pathPropertyInfo in PathProperties)
            {
                var jsonProperty = pathPropertyInfo.JsonProperty;

                // TODO: Case-insensitive JsonPath instead of SelectToken
                var pathToken = token.SelectToken(pathPropertyInfo.Path);
                if (pathToken == null)
                    continue;

                object propObj;
                if (jsonProperty.Converter != null)
                {
                    var propReader = pathToken.CreateReader();
                    propReader.Read();
                    propObj = jsonProperty.Converter.ReadJson(propReader, jsonProperty.PropertyType, null, serializer);
                }
                else
                {
                    propObj = pathToken.ToObject(jsonProperty.PropertyType, serializer);
                }
                jsonProperty.ValueProvider.SetValue(value, propObj);
            }

            return value;
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

        /// <summary>
        /// Creates and populates the root object using the default settings.
        /// </summary>
        /// <param name="token">The JSON token.</param>
        /// <param name="contract">The JSON contract.</param>
        /// <param name="serializer">The JSON serializer.</param>
        /// <returns>The created root object.</returns>
        private static object CreateRootObject(JToken token, JsonContract contract, JsonSerializer serializer)
        {
            var value = contract.DefaultCreator();
            serializer.Populate(token.CreateReader(), value);
            return value;
        }
    }
}
