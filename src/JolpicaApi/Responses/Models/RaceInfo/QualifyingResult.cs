using System;
using JolpicaApi.Serialization.Converters;
using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.RaceInfo
{
    /// <summary>
    /// Represents the qualifying result of a race.
    /// </summary>
    public class QualifyingResult : ResultBase
    {
        /// <summary>
        /// Gets the time for the first qualifying session (Q1).
        /// </summary>
        [JsonProperty(nameof(Q1))]
        [JsonConverter(typeof(StringTimeSpanConverter))]
        public TimeSpan? Q1 { get; private set; }

        /// <summary>
        /// Gets the time for the second qualifying session (Q2).
        /// </summary>
        [JsonProperty(nameof(Q2))]
        [JsonConverter(typeof(StringTimeSpanConverter))]
        public TimeSpan? Q2 { get; private set; }

        /// <summary>
        /// Gets the time for the third qualifying session (Q3).
        /// </summary>
        [JsonProperty(nameof(Q3))]
        [JsonConverter(typeof(StringTimeSpanConverter))]
        public TimeSpan? Q3 { get; private set; }
    }
}