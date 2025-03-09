using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.Standings
{
    /// <summary>
    /// Represents the standing of a driver in a racing season.
    /// </summary>
    public class DriverStanding : Standing
    {
        /// <summary>
        /// Gets or sets the driver associated with this standing.
        /// </summary>
        public Driver Driver { get; set; }

        /// <summary>
        /// Gets the latest constructor which the driver has driven for.
        /// </summary>
        public Constructor Constructor => AllConstructors.LastOrDefault();

        /// <summary>
        /// Gets or sets a list of all the constructors the driver has driven for up to this point in the season.
        /// </summary>
        [JsonProperty("Constructors")]
        public IList<Constructor> AllConstructors { get; set; }
    }
}