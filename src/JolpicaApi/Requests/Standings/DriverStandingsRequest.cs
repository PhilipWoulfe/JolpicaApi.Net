using JolpicaApi.Client.Attributes;
using JolpicaApi.Responses.Standings;

namespace JolpicaApi.Requests.Standings
{
    public class DriverStandingsRequest : StandingsRequest<DriverStandingsResponse>
    {
        [UrlTerminator, UrlSegment("driverStandings")]
        public int? DriverStanding { get; set; }
    }
}