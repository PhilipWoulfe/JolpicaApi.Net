using JolpiApi.Client.Attributes;
using JolpiApi.Responses.RaceInfo;

namespace JolpiApi.Requests.Standard
{
    public class SprintListRequest : StandardRequest<SprintListResponse>
    {
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        [UrlTerminator, UrlSegment("races")]
        protected object Races { get; }
    }
}
