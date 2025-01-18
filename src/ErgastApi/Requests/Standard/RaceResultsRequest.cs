using JolpiApi.Responses.RaceInfo;

namespace JolpiApi.Requests.Standard
{
    public class RaceResultsRequest : StandardRequest<RaceResultsResponse>
    {
        [UrlTerminator]
        public override int? FinishingPosition { get; set; }
    }
}