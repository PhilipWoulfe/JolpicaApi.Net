using JolpicaApi.Client.Attributes;
using JolpicaApi.Responses;

namespace JolpicaApi.Requests.Standings
{
    /// <summary>
    /// Represents a request for standings with a specific response type.
    /// </summary>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    public abstract class StandingsRequest<TResponse> : JolpicaRequest<TResponse> where TResponse : JolpicaResponse
    {
        /// <summary>
        /// Gets or sets the constructor ID.
        /// </summary>
        [UrlSegment("constructors")]
        public virtual string ConstructorId { get; set; }
    }
}