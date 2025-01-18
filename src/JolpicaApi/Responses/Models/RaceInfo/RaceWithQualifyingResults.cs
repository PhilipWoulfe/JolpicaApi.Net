using System.Collections.Generic;
using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.RaceInfo
{
    public class RaceWithQualifyingResults : Race
    {
        [JsonProperty(nameof(QualifyingResults))]
        public IList<QualifyingResult> QualifyingResults { get; private set; }
    }
}