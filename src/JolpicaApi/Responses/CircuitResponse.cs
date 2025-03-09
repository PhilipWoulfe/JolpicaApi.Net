using System.Collections.Generic;
using JolpicaApi.Responses.Models;
using JolpicaApi.Serialization;

namespace JolpicaApi.Responses
{
    /// <summary>
    /// Represents a response containing a list of circuits.
    /// </summary>
    public class CircuitResponse : JolpicaResponse
    {
        /// <summary>
        /// Gets the list of circuits.
        /// </summary>
        [JsonPathProperty("CircuitTable.Circuits")]
        public IList<Circuit> Circuits { get; private set; }
    }
}
