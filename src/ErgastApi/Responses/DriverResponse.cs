using System.Collections.Generic;
using JolpiApi.Responses.Models;
using JolpiApi.Serialization;

namespace JolpiApi.Responses
{
    public class DriverResponse : ErgastResponse
    {
        [JsonPathProperty("DriverTable.Drivers")]
        public IList<Driver> Drivers { get; private set; }
    }
}
