using JolpicaApi.Client.Attributes;
using JolpicaApi.Responses;

namespace JolpicaApi.Requests.Standard
{
    /// <summary>
    /// Represents a request for circuit information.
    /// </summary>
    public class CircuitInfoRequest : StandardRequest<CircuitResponse>
    {
        /// <summary>
        /// Gets or sets the circuit ID.
        /// </summary>
        [UrlTerminator]
        public override string CircuitId { get; set; }
    }
}