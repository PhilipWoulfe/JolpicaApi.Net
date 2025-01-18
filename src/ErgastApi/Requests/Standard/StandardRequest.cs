using JolpiApi.Client.Attributes;
using JolpiApi.Responses;
using JolpiApi.Responses.Models;

namespace JolpiApi.Requests.Standard
{
    public abstract class StandardRequest<TResponse> : ErgastRequest<TResponse> where TResponse : ErgastResponse
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