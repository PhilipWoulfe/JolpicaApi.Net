using System.Collections.Generic;
using Newtonsoft.Json;

namespace JolpiApi.Responses.Models.RaceInfo
{
    public class RaceWithQualifyingResults : Race
    {
        [JsonProperty(nameof(QualifyingResults))]
        public IList<QualifyingResult> QualifyingResults { get; private set; }
    }
}