using JolpicaApi.Serialization;
using System.Collections.Generic;

namespace JolpicaApi.Responses.Standings
{
    /// <summary>
    /// Represents a response containing standings information.
    /// </summary>
    /// <typeparam name="T">The type of the standings list items.</typeparam>
    public abstract class StandingsResponse<T> : JolpicaResponse
    {
        /// <summary>
        /// Gets the list of standings.
        /// </summary>
        [JsonPathProperty("StandingsTable.StandingsLists")]
        public IList<T> StandingsLists { get; private set; }
    }
}
