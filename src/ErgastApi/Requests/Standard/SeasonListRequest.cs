using JolpiApi.Client.Attributes;
using JolpiApi.Responses;

namespace JolpiApi.Requests.Standard
{
    public class SeasonListRequest : StandardRequest<SeasonResponse>
    {
        [UrlSegment("constructorStandings")]
        public int? ConstructorStanding { get; set; }

        [UrlSegment("driverStandings")]
        public int? DriverStanding { get; set; }

        // Value not used
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        [UrlTerminator, UrlSegment("seasons")]
        protected object Seasons { get; }
    }
}