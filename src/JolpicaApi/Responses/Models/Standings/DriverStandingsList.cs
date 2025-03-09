using System.Collections.Generic;
using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.Standings
{
    /// <summary>
    /// Represents a list of driver standings.
    /// </summary>
    public class DriverStandingsList : StandingsList<DriverStanding>
    {
        /// <summary>
        /// Gets or sets the list of driver standings.
        /// </summary>
        [JsonProperty("DriverStandings")]
        public override IList<DriverStanding> Standings { get; set; }
    }
}