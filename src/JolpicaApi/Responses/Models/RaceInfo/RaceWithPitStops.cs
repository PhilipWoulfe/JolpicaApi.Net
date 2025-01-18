using System.Collections.Generic;
using Newtonsoft.Json;

namespace JolpiApi.Responses.Models.RaceInfo
{
    public class RaceWithPitStops : Race
    {
        [JsonProperty(nameof(PitStops))]
        public IList<PitStopInfo> PitStops { get; private set; }
    }
}