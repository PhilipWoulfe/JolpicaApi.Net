using JolpicaApi.Client.Attributes;
using JolpicaApi.Responses;
using JolpicaApi.Responses.Models;

namespace JolpicaApi.Requests.Standard
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