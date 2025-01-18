using JolpicaApi.Client.Attributes;
using JolpicaApi.Responses;

namespace JolpicaApi.Requests.Standard
{
    /// <summary>
    /// Represents a request to retrieve a list of seasons.
    /// </summary>
    public class SeasonListRequest : StandardRequest<SeasonResponse>
    {
        /// <summary>
        /// Gets or sets the constructor standing to filter the results.
        /// </summary>
        [UrlSegment("constructorStandings")]
        public int? ConstructorStanding { get; set; }

        /// <summary>
        /// Gets or sets the driver standing to filter the results.
        /// </summary>
        [UrlSegment("driverStandings")]
        public int? DriverStanding { get; set; }

        // Value not used
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        /// <summary>
        /// Gets the seasons segment for the URL.
        /// </summary>
        [UrlTerminator, UrlSegment("seasons")]
        protected object Seasons { get; }
    }
}