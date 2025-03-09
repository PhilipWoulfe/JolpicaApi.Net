using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models
{
    /// <summary>
    /// Represents a season with a specific year and a Wikipedia URL.
    /// </summary>
    public class Season
    {
        /// <summary>
        /// Gets the year of the season.
        /// </summary>
        [JsonProperty("season")]
        public int Year { get; private set; }

        /// <summary>
        /// Gets the Wikipedia URL for the season.
        /// </summary>
        [JsonProperty("url")]
        public string WikiUrl { get; private set; }
    }
}
