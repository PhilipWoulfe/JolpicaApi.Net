using JolpicaApi.Client.Attributes;
using JolpicaApi.Responses.RaceInfo;

namespace JolpicaApi.Requests.Standard
{
    public class SprintListRequest : StandardRequest<SprintListResponse>
    {
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        [UrlTerminator, UrlSegment("races")]
        protected object Races { get; }
    }
}
