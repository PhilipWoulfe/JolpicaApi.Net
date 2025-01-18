using JolpiApi.Client.Attributes;
using JolpiApi.Responses.Standings;

namespace JolpiApi.Requests.Standings
{
    public class ConstructorStandingsRequest : StandingsRequest<ConstructorStandingsResponse>
    {
        [UrlTerminator, UrlSegment("constructorStandings")]
        public int? ConstructorStanding { get; set; }
    }
}