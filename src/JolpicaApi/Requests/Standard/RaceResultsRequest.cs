using JolpicaApi.Client.Attributes;
using JolpicaApi.Responses.RaceInfo;

namespace JolpicaApi.Requests.Standard
{
    /// <summary>
    /// Represents a request for race results.
    /// </summary>
    public class RaceResultsRequest : StandardRequest<RaceResultsResponse>
    {
        /// <summary>
        /// Gets or sets the finishing position.
        /// </summary>
        [UrlTerminator]
        public override int? FinishingPosition { get; set; }
    }
}