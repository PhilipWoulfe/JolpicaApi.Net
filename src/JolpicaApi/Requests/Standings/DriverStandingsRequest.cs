using JolpicaApi.Client.Attributes;
using JolpicaApi.Responses.Standings;

namespace JolpicaApi.Requests.Standings
{
    /// <summary>
    /// Represents a request for driver standings.
    /// </summary>
    public class DriverStandingsRequest : StandingsRequest<DriverStandingsResponse>
    {
        /// <summary>
        /// Gets or sets the driver standing.
        /// </summary>
        [UrlTerminator, UrlSegment("driverStandings")]
        public int? DriverStanding { get; set; }
    }
}