using System.Collections.Generic;
using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.RaceInfo
{
    /// <summary>
    /// Represents a race with pit stops information.
    /// </summary>
    public class RaceWithPitStops : Race
    {
        /// <summary>
        /// Gets the list of pit stops in the race.
        /// </summary>
        [JsonProperty(nameof(PitStops))]
        public IList<PitStopInfo> PitStops { get; private set; }
    }
}