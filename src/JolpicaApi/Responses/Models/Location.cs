using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models
{
    /// <summary>
    /// Represents a geographical location with latitude, longitude, locality, and country.
    /// </summary>
    public class Location
    {
        /// <summary>
        /// Gets the latitude of the location.
        /// </summary>
        [JsonProperty("lat")]
        public string Latitude { get; private set; }

        /// <summary>
        /// Gets the longitude of the location.
        /// </summary>
        [JsonProperty("long")]
        public string Longitude { get; private set; }

        /// <summary>
        /// Gets the locality of the location.
        /// </summary>
        [JsonProperty("locality")]
        public string Locality { get; private set; }

        /// <summary>
        /// Gets the country of the location.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; private set; }
    }
}