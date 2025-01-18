using System.Collections.Generic;
using JolpicaApi.Responses.Models;
using JolpicaApi.Serialization;

namespace JolpicaApi.Responses
{
    public class DriverResponse : JolpiResponse
    {
        [JsonPathProperty("DriverTable.Drivers")]
        public IList<Driver> Drivers { get; private set; }
    }
}
