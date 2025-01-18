using JolpiApi.Responses;

namespace JolpiApi.Requests.Standard
{
    public class CircuitInfoRequest : StandardRequest<CircuitResponse>
    {
        [UrlTerminator]
        public override string CircuitId { get; set; }
    }
}