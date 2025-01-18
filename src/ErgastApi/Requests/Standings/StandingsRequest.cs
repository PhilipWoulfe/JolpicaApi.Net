using JolpiApi.Client.Attributes;
using JolpiApi.Responses;

namespace JolpiApi.Requests.Standings
{
    public abstract class StandingsRequest<TResponse> : ErgastRequest<TResponse> where TResponse : ErgastResponse
    {
        [UrlSegment("constructors")]
        public virtual string ConstructorId { get; set; }
    }
}