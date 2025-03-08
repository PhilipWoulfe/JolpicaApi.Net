using JolpicaApi.Client.Attributes;
using JolpicaApi.Responses.RaceInfo;

namespace JolpicaApi.Requests
{
    /// <summary>
    /// Represents a request for lap times data.
    /// </summary>
    public class LapTimesRequest : JolpicaRequest<LapTimesResponse>
    {
        /// <summary>
        /// Gets or sets the lap number.
        /// </summary>
        [UrlTerminator, UrlSegment("laps")]
        public int? Lap { get; set; }

        /// <summary>
        /// Gets or sets the pit stop number.
        /// </summary>
        [UrlSegment("pitstops")]
        public int? PitStop { get; set; }
    }
}