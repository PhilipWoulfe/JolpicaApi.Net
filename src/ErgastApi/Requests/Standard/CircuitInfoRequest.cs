using JolpiApi.Client.Attributes;
using JolpiApi.Responses;

namespace JolpiApi.Requests.Standard
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