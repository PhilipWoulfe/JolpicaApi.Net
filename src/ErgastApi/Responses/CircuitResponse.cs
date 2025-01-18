using System.Collections.Generic;
using JolpiApi.Responses.Models;
using JolpiApi.Serialization;

namespace JolpiApi.Responses
{
    public class CircuitResponse : ErgastResponse
    {
        [JsonPathProperty("CircuitTable.Circuits")]
        public IList<Circuit> Circuits { get; private set; }
    }
}
