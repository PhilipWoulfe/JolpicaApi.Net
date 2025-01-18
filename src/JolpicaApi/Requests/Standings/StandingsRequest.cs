using JolpiApi.Client.Attributes;
using JolpiApi.Responses;

namespace JolpiApi.Requests.Standings
{
    public abstract class StandingsRequest<TResponse> : JolpiRequest<TResponse> where TResponse : JolpiResponse
    {
        [UrlSegment("constructors")]
        public virtual string ConstructorId { get; set; }
    }
}