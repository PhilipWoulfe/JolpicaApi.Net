using System.Collections.Generic;
using Newtonsoft.Json;

namespace JolpiApi.Responses.Models.RaceInfo
{
    public class RaceWithLapTimes : Race
    {
        [JsonProperty(nameof(Laps))]
        public IList<Lap> Laps { get; private set; }
    }
}