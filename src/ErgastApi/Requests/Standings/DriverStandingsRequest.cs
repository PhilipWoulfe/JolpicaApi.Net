using JolpiApi.Client.Attributes;
using JolpiApi.Responses.Standings;

namespace JolpiApi.Requests.Standings
{
    public class DriverStandingsRequest : StandingsRequest<DriverStandingsResponse>
    {
        [UrlTerminator, UrlSegment("driverStandings")]
        public int? DriverStanding { get; set; }
    }
}