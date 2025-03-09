using System;
using JolpicaApi.Serialization.Converters;
using Newtonsoft.Json;

namespace JolpicaApi.Responses.Models.RaceInfo
{
    /// <summary>
    /// Represents information about a pit stop in a race.
    /// </summary>
    public class PitStopInfo
    {
        /// <summary>
        /// Gets the ID of the driver.
        /// </summary>
        [JsonProperty("driverId")]
        public string DriverId { get; private set; }

        /// <summary>
        /// Gets the lap number when the pit stop occurred.
        /// </summary>
        [JsonProperty("lap")]
        public int Lap { get; private set; }

        /// <summary>
        /// Gets the stop number of the pit stop.
        /// </summary>
        [JsonProperty("stop")]
        public int Stop { get; private set; }

        /// <summary>
        /// Gets the time of day when the pit stop occurred.
        /// </summary>
        [JsonProperty("time")]
        [JsonConverter(typeof(StringTimeSpanConverter))]
        public TimeSpan TimeOfDay { get; private set; }

        /// <summary>
        /// Gets the duration of the pit stop.
        /// </summary>
        [JsonProperty("duration")]
        [JsonConverter(typeof(SecondsTimeSpanConverter))]
        public TimeSpan Duration { get; private set; }
    }
}