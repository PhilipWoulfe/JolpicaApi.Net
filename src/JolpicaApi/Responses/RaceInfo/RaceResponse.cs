using System.Collections.Generic;
using JolpicaApi.Responses.Models.RaceInfo;
using JolpicaApi.Serialization;

namespace JolpicaApi.Responses.RaceInfo
{
    /// <summary>
    /// Represents a response containing race information.
    /// </summary>
    /// <typeparam name="T">The type of race.</typeparam>
    public abstract class RaceResponse<T> : JolpicaResponse where T : Race
    {
        /// <summary>
        /// Gets or sets the list of races.
        /// </summary>
        [JsonPathProperty("RaceTable.Races")]
        public IList<T> Races { get; set; }
    }
}
