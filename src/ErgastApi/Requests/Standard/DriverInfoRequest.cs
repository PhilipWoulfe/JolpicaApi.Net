using JolpiApi.Responses;

namespace JolpiApi.Requests.Standard
{
    public class DriverInfoRequest : StandardRequest<DriverResponse>
    {
        [UrlTerminator]
        public override string DriverId { get; set; }
    }
}
