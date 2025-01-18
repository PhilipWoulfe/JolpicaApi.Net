using JolpicaApi.Client.Attributes;
using JolpicaApi.Responses.RaceInfo;

namespace JolpicaApi.Requests.Standard
{
    public class SprintResultsRequest : StandardRequest<SprintResultsResponse>
    {
        [UrlTerminator, UrlSegment("sprint")]
        public override int? FinishingPosition { get; set; }
    }
}
