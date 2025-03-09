using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models
{
    /// <summary>
    /// Represents a constructor with details such as ID, URL, name, and nationality.
    /// </summary>
    public class Constructor
    {
        /// <summary>
        /// Gets the constructor ID.
        /// </summary>
        [JsonProperty("constructorId")]
        public string ConstructorId { get; private set; }

        /// <summary>
        /// Gets the Wikipedia URL of the constructor.
        /// </summary>
        [JsonProperty("url")]
        public string WikiUrl { get; private set; }

        /// <summary>
        /// Gets the name of the constructor.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the nationality of the constructor.
        /// </summary>
        [JsonProperty("nationality")]
        public string Nationality { get; private set; }
    }
}