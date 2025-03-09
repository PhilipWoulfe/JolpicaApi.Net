using System.Collections.Generic;
using JolpicaApi.Responses.Models;
using JolpicaApi.Serialization;

namespace JolpicaApi.Responses
{
    /// <summary>
    /// Represents a response containing a list of drivers.
    /// </summary>
    public class DriverResponse : JolpicaResponse
    {
        /// <summary>
        /// Gets the list of drivers.
        /// </summary>
        [JsonPathProperty("DriverTable.Drivers")]
        public IList<Driver> Drivers { get; private set; }
    }
}
