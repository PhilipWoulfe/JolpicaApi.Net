using JolpiApi.Responses;

namespace JolpiApi.Requests.Standard
{
    public class ConstructorInfoRequest : StandardRequest<ConstructorResponse>
    {
        [UrlTerminator]
        public override string ConstructorId { get; set; }
    }
}