using System.Collections.Generic;
using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.RaceInfo
{
    /// <summary>
    /// Represents a race with lap times.
    /// </summary>
    public class RaceWithLapTimes : Race
    {
        /// <summary>
        /// Gets the list of laps in the race.
        /// </summary>
        [JsonProperty(nameof(Laps))]
        public IList<Lap> Laps { get; private set; }
    }
}