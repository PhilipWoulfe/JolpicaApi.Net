using System.Collections.Generic;
using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.RaceInfo
{
    public class RaceWithPitStops : Race
    {
        [JsonProperty(nameof(PitStops))]
        public IList<PitStopInfo> PitStops { get; private set; }
    }
}