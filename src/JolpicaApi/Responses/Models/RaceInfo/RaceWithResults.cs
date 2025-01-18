using System.Collections.Generic;
using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.RaceInfo
{
    public class RaceWithResults : Race
    {
        [JsonProperty(nameof(Results))]
        public IList<RaceResult> Results { get; private set; }
    }
}