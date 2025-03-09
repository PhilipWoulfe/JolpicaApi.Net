using System.Collections.Generic;
using JolpicaApi.Responses.Models;

using JolpicaApi.Serialization;
namespace JolpicaApi.Responses
{
    /// <summary>
    /// Represents a response containing a list of seasons.
    /// </summary>
    public class SeasonResponse : JolpicaResponse
    {
        /// <summary>
        /// Gets the list of seasons.
        /// </summary>
        [JsonPathProperty("SeasonTable.Seasons")]
        public IList<Season> Seasons { get; private set; }
    }
}
