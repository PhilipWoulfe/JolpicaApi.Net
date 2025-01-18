using JolpiApi.Client.Attributes;
using JolpiApi.Responses;
using JolpiApi.Responses.Models;

namespace JolpiApi.Requests.Standard
{
    /// <summary>
    /// Represents a request for finishing status information.
    /// </summary>
    public class FinishingStatusRequest : StandardRequest<FinishingStatusResponse>
    {
        /// <summary>
        /// Gets or sets the finishing status.
        /// </summary>
        [UrlTerminator]
        public override FinishingStatusId? FinishingStatus { get; set; }
    }
}