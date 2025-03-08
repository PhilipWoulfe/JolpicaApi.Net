using System.Collections.Generic;
using JolpicaApi.Responses.Models;
using JolpicaApi.Serialization;

namespace JolpicaApi.Responses
{
    public class CircuitResponse : JolpicaResponse
    {
        [JsonPathProperty("CircuitTable.Circuits")]
        public IList<Circuit> Circuits { get; private set; }
    }
}
