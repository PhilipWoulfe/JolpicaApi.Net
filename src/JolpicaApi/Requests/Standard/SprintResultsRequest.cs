using JolpicaApi.Client.Attributes;
using JolpicaApi.Responses.RaceInfo;

namespace JolpicaApi.Requests.Standard
{
    /// <summary>
    /// Represents a request for sprint race results.
    /// </summary>
    public class SprintResultsRequest : StandardRequest<SprintResultsResponse>
    {
        /// <summary>
        /// Gets or sets the finishing position for the sprint race.
        /// </summary>
        [UrlTerminator, UrlSegment("sprint")]
        public override int? FinishingPosition { get; set; }
    }
}
