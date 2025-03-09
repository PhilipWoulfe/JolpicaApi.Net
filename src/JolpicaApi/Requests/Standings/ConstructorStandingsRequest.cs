using JolpicaApi.Client.Attributes;
using JolpicaApi.Responses.Standings;

namespace JolpicaApi.Requests.Standings
{
    /// <summary>
    /// Represents a request for constructor standings.
    /// </summary>
    public class ConstructorStandingsRequest : StandingsRequest<ConstructorStandingsResponse>
    {
        /// <summary>
        /// Gets or sets the constructor standing.
        /// </summary>
        [UrlTerminator, UrlSegment("constructorStandings")]
        public int? ConstructorStanding { get; set; }
    }
}