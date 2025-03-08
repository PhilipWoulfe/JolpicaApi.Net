using JolpicaApi.Client.Attributes;
using JolpicaApi.Responses;

namespace JolpicaApi.Requests.Standings
{
    public abstract class StandingsRequest<TResponse> : JolpicaRequest<TResponse> where TResponse : JolpicaResponse
    {
        [UrlSegment("constructors")]
        public virtual string ConstructorId { get; set; }
    }
}