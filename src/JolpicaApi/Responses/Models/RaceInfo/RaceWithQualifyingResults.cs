using System.Collections.Generic;
using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.RaceInfo
{
    /// <summary>
    /// Represents a race with qualifying results.
    /// </summary>
    public class RaceWithQualifyingResults : Race
    {
        /// <summary>
        /// Gets the list of qualifying results.
        /// </summary>
        [JsonProperty(nameof(QualifyingResults))]
        public IList<QualifyingResult> QualifyingResults { get; private set; }
    }
}