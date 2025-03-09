using Newtonsoft.Json.Serialization;

namespace JolpicaApi.Serialization
{
    /// <summary>
    /// Represents information about a JSON property and its associated path.
    /// </summary>
    public class JsonPathPropertyInfo
    {
        /// <summary>
        /// Gets or sets the JSON property.
        /// </summary>
        public JsonProperty JsonProperty { get; set; }

        /// <summary>
        /// Gets or sets the path of the JSON property.
        /// </summary>
        public string Path { get; set; }
    }
}
