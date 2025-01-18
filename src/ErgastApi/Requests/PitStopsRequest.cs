using JolpiApi.Client.Attributes;
using JolpiApi.Responses.RaceInfo;

namespace JolpiApi.Requests
{
    public class PitStopsRequest : ErgastRequest<PitStopsResponse>
    {
        [UrlSegment("laps")]
        public int? Lap { get; set; }

        [UrlTerminator, UrlSegment("pitstops")]
        public int? PitStop { get; set; }
    }
}