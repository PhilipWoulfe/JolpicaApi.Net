using System;
using JolpicaApi.Serialization;
using JolpicaApi.Serialization.Converters;
using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.RaceInfo
{
    /// <summary>
    /// Represents the fastest lap information in a race.
    /// </summary>
    public class FastestLap
    {
        /// <summary>
        /// Gets the rank of the fastest lap.
        /// </summary>
        [JsonProperty("rank")]
        public int Rank { get; private set; }

        /// <summary>
        /// Gets the lap number of the fastest lap.
        /// </summary>
        [JsonProperty("lap")]
        public int LapNumber { get; private set; }

        /// <summary>
        /// Gets the time of the fastest lap.
        /// </summary>
        [JsonPathProperty("Time.time")]
        [JsonConverter(typeof(StringTimeSpanConverter))]
        public TimeSpan? LapTime { get; private set; }

        /// <summary>
        /// Gets the average speed of the fastest lap.
        /// </summary>
        [JsonProperty(nameof(AverageSpeed))]
        public AverageSpeed AverageSpeed { get; private set; }
    }
}