using System;
using JolpiApi.Serialization;
using JolpiApi.Serialization.Converters;
using Newtonsoft.Json;

namespace JolpiApi.Responses.Models.RaceInfo
{
    public class FastestLap
    {
        [JsonProperty("rank")]
        public int Rank { get; private set; }

        [JsonProperty("lap")]
        public int LapNumber { get; private set; }

        [JsonPathProperty("Time.time")]
        [JsonConverter(typeof(StringTimeSpanConverter))]
        public TimeSpan? LapTime { get; private set; }

        [JsonProperty(nameof(AverageSpeed))]
        public AverageSpeed AverageSpeed { get; private set; }
    }
}