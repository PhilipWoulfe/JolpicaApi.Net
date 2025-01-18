using System.Collections.Generic;
using JolpiApi.Responses.Models;

namespace JolpiApi.Responses
{
    public class DriverResponse : ErgastResponse
    {
        [JsonPathProperty("DriverTable.Drivers")]
        public IList<Driver> Drivers { get; private set; }
    }
}
