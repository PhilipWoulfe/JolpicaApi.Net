using System.Collections.Generic;
using JolpiApi.Responses.Models;
using JolpiApi.Serialization;

namespace JolpiApi.Responses
{
    public class CircuitResponse : JolpiResponse
    {
        [JsonPathProperty("CircuitTable.Circuits")]
        public IList<Circuit> Circuits { get; private set; }
    }
}
