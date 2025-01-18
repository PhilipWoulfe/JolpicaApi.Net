using JolpiApi.Client.Attributes;
using JolpiApi.Responses;

namespace JolpiApi.Requests.Standard
{
    /// <summary>
    /// Request class for retrieving constructor information.
    /// </summary>
    public class ConstructorInfoRequest : StandardRequest<ConstructorResponse>
    {
        /// <summary>
        /// Gets or sets the constructor ID.
        /// </summary>
        [UrlTerminator]
        public override string ConstructorId { get; set; }
    }
}