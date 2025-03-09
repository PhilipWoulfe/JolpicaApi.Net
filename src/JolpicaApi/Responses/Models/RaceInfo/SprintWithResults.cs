using System.Collections.Generic;
using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.RaceInfo
{
    /// <summary>
    /// Represents a sprint race with its results.
    /// </summary>
    public class SprintWithResults : Race
    {
        /// <summary>
        /// Gets the list of sprint race results.
        /// </summary>
        [JsonProperty(nameof(SprintResults))]
        public IList<RaceResult> SprintResults { get; private set; }
    }
}
