using JolpicaApi.Client.Attributes;
using JolpicaApi.Responses;

namespace JolpicaApi.Requests.Standard
{
    /// <summary>
    /// Represents a request for driver information.
    /// </summary>
    public class DriverInfoRequest : StandardRequest<DriverResponse>
    {
        /// <summary>
        /// Gets or sets the driver ID.
        /// </summary>
        [UrlTerminator]
        public override string DriverId { get; set; }
    }
}
