using JolpicaApi.Client.Attributes;
using JolpicaApi.Responses;
using JolpicaApi.Responses.Models;

namespace JolpicaApi.Requests.Standard
{
    /// <summary>
    /// Represents a standard request with various parameters for querying data.
    /// </summary>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    public abstract class StandardRequest<TResponse> : JolpicaRequest<TResponse> where TResponse : JolpicaResponse
    {
        /// <summary>
        /// Gets or sets the constructor ID.
        /// </summary>
        [UrlSegment("constructors")]
        public virtual string ConstructorId { get; set; }

        /// <summary>
        /// Gets or sets the circuit ID.
        /// </summary>
        [UrlSegment("circuits")]
        public virtual string CircuitId { get; set; }

        /// <summary>
        /// Gets or sets the fastest lap rank.
        /// </summary>
        [UrlSegment("fastest")]
        public virtual int? FastestLapRank { get; set; }

        /// <summary>
        /// Gets or sets the finishing position.
        /// </summary>
        [UrlSegment("results")]
        public virtual int? FinishingPosition { get; set; }

        /// <summary>
        /// Gets or sets the qualifying position (grid position).
        /// </summary>
        [UrlSegment("grid")]
        public virtual int? QualifyingPosition { get; set; }

        /// <summary>
        /// Gets or sets the finishing status.
        /// </summary>
        [UrlSegment("status")]
        public virtual FinishingStatusId? FinishingStatus { get; set; }
    }
}