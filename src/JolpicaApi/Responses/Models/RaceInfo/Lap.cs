using System.Collections.Generic;
using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.RaceInfo
{
    /// <summary>
    /// Represents a lap in a race, including the lap number and timings for each driver.
    /// </summary>
    public class Lap
    {
        /// <summary>
        /// Gets the lap number.
        /// </summary>
        [JsonProperty("number")]
        public int Number { get; private set; }

        /// <summary>
        /// Gets the list of timings for each driver in this lap.
        /// </summary>
        [JsonProperty(nameof(Timings))]
        public IList<LapTiming> Timings { get; private set; }
    }
}