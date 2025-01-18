using JolpicaApi.Client.Attributes;
using JolpicaApi.Responses;

namespace JolpicaApi.Requests.Standings
{
    public abstract class StandingsRequest<TResponse> : JolpiRequest<TResponse> where TResponse : JolpiResponse
    {
        [UrlSegment("constructors")]
        public virtual string ConstructorId { get; set; }
    }
}