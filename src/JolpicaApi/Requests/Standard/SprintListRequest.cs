using JolpicaApi.Client.Attributes;
using JolpicaApi.Responses.RaceInfo;

namespace JolpicaApi.Requests.Standard
{
    /// <summary>
    /// Represents a request for a list of sprint races.
    /// </summary>
    public class SprintListRequest : StandardRequest<SprintListResponse>
    {
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        /// <summary>
        /// Gets the races.
        /// </summary>
        [UrlTerminator, UrlSegment("races")]
        protected object Races { get; }
    }
}
