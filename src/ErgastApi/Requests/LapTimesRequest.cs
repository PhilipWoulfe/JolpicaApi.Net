using JolpiApi.Client.Attributes;
using JolpiApi.Responses.RaceInfo;

namespace JolpiApi.Requests
{
    public class LapTimesRequest : ErgastRequest<LapTimesResponse>
    {
        [UrlTerminator, UrlSegment("laps")]
        public int? Lap { get; set; }

        [UrlSegment("pitstops")]
        public int? PitStop { get; set; }
    }
}