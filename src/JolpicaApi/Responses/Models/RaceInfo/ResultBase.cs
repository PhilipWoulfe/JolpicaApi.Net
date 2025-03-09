using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.RaceInfo
{
    /// <summary>
    /// Represents the base class for race results.
    /// </summary>
    public abstract class ResultBase
    {
        /// <summary>
        /// Gets the number of the result.
        /// </summary>
        [JsonProperty("number")]
        public int Number { get; private set; }

        /// <summary>
        /// Gets the position of the result.
        /// </summary>
        [JsonProperty("position")]
        public int Position { get; private set; }

        /// <summary>
        /// Gets the driver associated with the result.
        /// </summary>
        [JsonProperty(nameof(Driver))]
        public Driver Driver { get; private set; }

        /// <summary>
        /// Gets the constructor associated with the result.
        /// </summary>
        [JsonProperty(nameof(Constructor))]
        public Constructor Constructor { get; private set; }
    }
}