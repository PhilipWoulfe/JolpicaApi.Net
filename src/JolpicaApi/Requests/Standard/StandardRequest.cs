using JolpicaApi.Client.Attributes;
using JolpicaApi.Responses;
using JolpicaApi.Responses.Models;

namespace JolpicaApi.Requests.Standard
{
    public abstract class StandardRequest<TResponse> : JolpiRequest<TResponse> where TResponse : JolpiResponse
    {
        [UrlSegment("constructors")]
        public virtual string ConstructorId { get; set; }

        [UrlSegment("circuits")]
        public virtual string CircuitId { get; set; }

        [UrlSegment("fastest")]
        public virtual int? FastestLapRank { get; set; }

        [UrlSegment("results")]
        public virtual int? FinishingPosition { get; set; }

        // Grid / starting position
        [UrlSegment("grid")]
        public virtual int? QualifyingPosition { get; set; }

        [UrlSegment("status")]
        public virtual FinishingStatusId? FinishingStatus { get; set; }
    }
}