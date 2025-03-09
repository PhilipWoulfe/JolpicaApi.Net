using System.Collections.Generic;
using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.RaceInfo
{
    /// <summary>
    /// Represents a race with its results.
    /// </summary>
    public class RaceWithResults : Race
    {
        /// <summary>
        /// Gets the list of race results.
        /// </summary>
        [JsonProperty(nameof(Results))]
        public IList<RaceResult> Results { get; private set; }
    }
}