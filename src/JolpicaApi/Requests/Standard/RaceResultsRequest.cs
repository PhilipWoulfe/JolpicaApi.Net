using JolpiApi.Client.Attributes;
using JolpiApi.Responses.RaceInfo;

namespace JolpiApi.Requests.Standard
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