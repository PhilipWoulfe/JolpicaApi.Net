using JolpiApi.Client.Attributes;
using JolpiApi.Responses.RaceInfo;

namespace JolpiApi.Requests.Standard
{
    public class SprintResultsRequest : StandardRequest<SprintResultsResponse>
    {
        [UrlTerminator, UrlSegment("sprint")]
        public override int? FinishingPosition { get; set; }
    }
}
