using System;
using JolpiApi.Serialization.Converters;
using Newtonsoft.Json;

namespace JolpiApi.Responses.Models.RaceInfo
{
    public class QualifyingResult : ResultBase
    {
        [JsonProperty(nameof(Q1))]
        [JsonConverter(typeof(StringTimeSpanConverter))]
        public TimeSpan? Q1 { get; private set; }

        [JsonProperty(nameof(Q2))]
        [JsonConverter(typeof(StringTimeSpanConverter))]
        public TimeSpan? Q2 { get; private set; }

        [JsonProperty(nameof(Q3))]
        [JsonConverter(typeof(StringTimeSpanConverter))]
        public TimeSpan? Q3 { get; private set; }
    }
}