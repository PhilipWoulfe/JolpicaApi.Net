using JolpiApi.Client.Attributes;

namespace JolpiApi.Requests.Standard
{
    public class RaceListRequest : StandardRequest<RaceListResponse>
    {
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        [UrlTerminator, UrlSegment("races")]
        protected object Races { get; }
    }
}