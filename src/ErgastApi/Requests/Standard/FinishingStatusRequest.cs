using JolpiApi.Responses;
using JolpiApi.Responses.Models;

namespace JolpiApi.Requests.Standard
{
    public class FinishingStatusRequest : StandardRequest<FinishingStatusResponse>
    {
        [UrlTerminator]
        public override FinishingStatusId? FinishingStatus { get; set; }
    }
}