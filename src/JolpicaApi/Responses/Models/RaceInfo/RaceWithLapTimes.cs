using System.Collections.Generic;
using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.RaceInfo
{
    public class RaceWithLapTimes : Race
    {
        [JsonProperty(nameof(Laps))]
        public IList<Lap> Laps { get; private set; }
    }
}