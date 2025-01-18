using JolpiApi.Client.Attributes;

namespace JolpiApi.Requests.Standard
{
    public class QualifyingResultsRequest : StandardRequest<QualifyingResultsResponse>
    {
        [UrlTerminator, UrlSegment("qualifying")]
        public override int? QualifyingPosition { get; set; }
    }
}