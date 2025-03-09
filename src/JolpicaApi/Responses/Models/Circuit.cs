using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models
{
    /// <summary>
    /// Represents a racing circuit with its details.
    /// </summary>
    public class Circuit
    {
        /// <summary>
        /// Gets the unique identifier of the circuit.
        /// </summary>
        [JsonProperty("circuitId")]
        public string CircuitId { get; private set; }

        /// <summary>
        /// Gets the name of the circuit.
        /// </summary>
        [JsonProperty("circuitName")]
        public string CircuitName { get; private set; }

        /// <summary>
        /// Gets the Wikipedia URL of the circuit.
        /// </summary>
        [JsonProperty("url")]
        public string WikiUrl { get; private set; }

        /// <summary>
        /// Gets the location details of the circuit.
        /// </summary>
        [JsonProperty("location")]
        public Location Location { get; private set; }
    }
}