using JolpicaApi.Client.Attributes;
using JolpicaApi.Responses.Standings;

namespace JolpicaApi.Requests.Standings
{
    public class ConstructorStandingsRequest : StandingsRequest<ConstructorStandingsResponse>
    {
        [UrlTerminator, UrlSegment("constructorStandings")]
        public int? ConstructorStanding { get; set; }
    }
}