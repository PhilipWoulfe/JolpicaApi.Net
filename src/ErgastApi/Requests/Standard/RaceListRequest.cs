using JolpiApi.Client.Attributes;
using JolpiApi.Responses.RaceInfo;

namespace JolpiApi.Requests.Standard
{
    /// <summary>
    /// Represents a request to retrieve a list of races.
    /// </summary>
    public class RaceListRequest : StandardRequest<RaceListResponse>
    {
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        /// <summary>
        /// Gets the races.
        /// </summary>
        [UrlTerminator, UrlSegment("races")]
        protected object Races { get; }
    }
}